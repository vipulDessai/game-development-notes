# Weapon System [Tutorial Link](https://www.youtube.com/watch?v=vbvD0kuSCDs)

## Weapons
- add blueprint class (right click in content browser)
    - of type "SkeletalMeshComponent" under "ActorComponent"
        - rename it to BP_WeaponMaster
    - add enums
        - E_FireMode
        - E_WeaponNames
        - E_WeaponTypes

## Pickup Functionality
- add a blueprint actor class -> rename it to BP_PickupMaster
- open its blueprint and add a static mesh
- drag the mesh onto the "DefaultSceneRoot" to replace the root with mesh (otherwise collision wont work)
- add sphere collision (a transparent sphere)
    - set its radius to 100
- select the new root element
- <img src="./images/set-properties-actor-weapon-game.png">
- in details
    - under static mesh add any mesh so that we can select this root element by clicking on this selected mesh
    - enable "simulate physics" 
    - under "component tick" 
        - disable "Start with tick enabled"
    - set mass 60kg
    - under physics
        - liner damping 0.25
        - angular damping 0.25
- craete a blueprint interface
    - rename BPI_Interact
    - rename its function to `Interact`
    - add input "CharacterPickingUp" and type in `BP_ThirdPersonCharacter`
- add "BPI_Interact" blueprint interface to BP_PickupMaster
- create a child class from `BP_PickupMaster`
    - right click -> Create Child Blueprint class -> rename BP_WeaponPickup
    - create a variable "WeaponToSpawn" and add type as "BP_WeaponMaster" as class reference
        - compile 
        - in details set default value to "BP_WeaponMaster" reference
