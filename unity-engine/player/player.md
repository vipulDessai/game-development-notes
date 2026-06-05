# **Player**

## import

- configure the avatar

### Add movement script

- refer `./scripts/MovementScript.cs`

## Add Animation

### setup the baked animation from FBX file

- Rig Settings
  - select the rig as humanoid and copy from existing avatar
- under the animation tab
  - <img src="./images/anim-import-1.png" />
  - <img src="./images/anim-import-2.png" />
      - make sure the Transform Position (Y) is Based Upon - Feet

### Animation controller

- add or create animation controller under projects
- <img src="./images/anim-controller.png" />
- add the animation clips from the imported
- add the controller as component to `unity's player 3d object`
- <img src="./images/add-player-anim-controller.png" />

### Script animator

```cs
private Animator animator;

[RequireComponent(typeof(CharacterController))]
public class MovementScript : MonoBehaviour
{
    void Start()
    {
        // find animator if not assigned
        if (animator == null)
        {
            animator = GetComponent<Animator>();
            if (animator == null)
                Debug.LogWarning("No Animator found. Assign an Animator or add one as a child.");
        }
    }
}
```
