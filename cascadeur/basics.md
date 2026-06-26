# Cascadeur

# start - reset or new scene

- press the home button at the top left corner

# Viewport

## movement

- alt + click to rotate
- alt + middle to pan
- alt + right to zoom

## move entire mesh (without auto pose)

- <img src="./images/basics/drag-whole-model.png">
- the blue marker is the root bone, move that and it will move the entire mesh without applying the auto pose

## hide the mesh

- using the animation track, we can click on the view button
- <img src="./images/basics/hide-mesh.gif">

## hide the bones or control points

- v

### unhide the bones or control points

- alt + v

## No animation keyframe to mesh

- click on the lock in tracks
- <img src="./images/basics/lock-track.png">

# Tracks

## rename

- right click on track name, type the name

# Manipulators (gizmo)

<img src="./images/what-is-manipulators.png">

## Modes

- global or local
- <img src="./images/switch-global-mode-manipulator.png">
    - global for along the floor or env
    - local for rotating along the characters body parts
        - like rotating the limbs

## select

- <img src="./images/show-select-transform-panel.png">
- after opening
- <img src="./images/transform-armature-animation.png">
- note that select and moving the bone freezes it

### all

- <img src="./images/double-click-pelvis-select-all.png">
    -double click on pelvis to select all points

### unfreeze the bone

- click on the bone
- shift + z
- or click this
  - <img src="./images/unfreeze-manipulator.png">

# Rigging Setup

- <img src="./images/basics/rigging-auto-mirro-fill.png">
- fill the left or right side only
- then add the letters distinguishing the sides (ex .L and .R)
- so if left hand is manually filled, original is .L and mirrored is .R
- go to right hand and click on `Create Mirror object`

## enable fingers

- <img src="./images/basics/enable-fingers-auto-pose.png">

# Import

## how to import 2 rigged character in 1 scene

- first create 2 scnes with individual rigged charactor setting up the auto physics
- then import the other one into first scene
- <img src="./images/basics/import-another-rigged-model.png">
