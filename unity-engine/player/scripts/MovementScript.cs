using UnityEngine;
using UnityEngine.InputSystem;


[RequireComponent(typeof(CharacterController))]
public class MovementScript : MonoBehaviour
{
    public float speed = 5f;
    public float rotationSpeed = 10f;
    public float gravity = -9.81f;


    private CharacterController controller;
    private Transform cam;
    private Vector3 velocity;
    private Vector2 moveInput;

    private Animator animator; // assign in Inspector or will try to find in children
    private string speedParam = "Speed";
    private string crouchParam = "IsCrouching";

    private bool isCrouching;
    private float originalHeight;
    private Vector3 originalCenter;

    void Start()
    {
        controller = GetComponent<CharacterController>();

        if (Camera.main == null) { 
            Debug.LogError("No MainCamera."); 
            enabled = false; 
            return; 
        }

        cam = Camera.main.transform;

        // cache original controller values for crouch restore
        originalHeight = controller.height;
        originalCenter = controller.center;

        // find animator if not assigned
        if (animator == null)
        {
            animator = GetComponent<Animator>();
            if (animator == null)
                Debug.LogWarning("No Animator found. Assign an Animator or add one as a child.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Read keyboard directly (simplest approach)
        moveInput = Vector2.zero;
        var kb = Keyboard.current;
        if (kb != null)
        {
            if (kb.wKey.isPressed) moveInput.y += 1;
            if (kb.sKey.isPressed) moveInput.y -= 1;
            if (kb.dKey.isPressed) moveInput.x += 1;
            if (kb.aKey.isPressed) moveInput.x -= 1;
        }

        // crouch input (hold Left Ctrl to crouch)
        bool wantCrouch = false;
        if (kb != null && kb.leftCtrlKey != null)
            wantCrouch = kb.leftCtrlKey.isPressed;

        // apply crouch state and adjust controller
        if (wantCrouch && !isCrouching)
            SetCrouch(true);
        else if (!wantCrouch && isCrouching)
            SetCrouch(false);

        Vector3 input = new Vector3(moveInput.x, 0f, moveInput.y).normalized;

        // set animator Speed (use input magnitude)
        if (animator != null)
            animator.SetFloat(speedParam, input.magnitude);

        if (input.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(input.x, input.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.LerpAngle(transform.eulerAngles.y, targetAngle, rotationSpeed * Time.deltaTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            controller.Move(moveDir * speed * Time.deltaTime);
        }

        if (controller.isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }

    private void SetCrouch(bool crouch)
    {
        float crouchHeight = 1.0f;

        isCrouching = crouch;

        // Animator boolean
        if (animator != null)
            animator.SetBool(crouchParam, crouch);

        // Adjust CharacterController collider height/center
        if (crouch)
        {
            //controller.height = Mathf.Min(crouchHeight, originalHeight);
            Vector3 c = controller.center;
            c.y = controller.height / 2f;
            controller.center = c;
        }
        else
        {
            controller.height = originalHeight;
            controller.center = originalCenter;
        }
    }
}
