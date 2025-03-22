# Game Mode
- For third person shooter template, the game mode has a "Default Pawn Class" setting pointing to `/Game/ThirdPerson/Blueprints/BP_ThirdPersonCharacter`
- so when the game starts the player controller posseses the default pawn specified by the game mode
    - which is `BP_ThirdPersonCharacter`

# Blueprint Third person character class (project's character class)

## access
- Casting: Allows a Blueprint to verify and access specific variables/functions of the BP_ThirdPersonCharacter by confirming its type.
- Object References: Provides a direct, stored link for efficient, ongoing communication between Blueprints and the BP_ThirdPersonCharacter.
- Event Dispatchers: Enables decoupled communication via custom messaging, where Blueprints can send and receive events related to the BP_ThirdPersonCharacter.
- Interfaces: Creates modular communication through shared function definitions, allowing diverse Blueprints to interact consistently with the BP_ThirdPersonCharacter.