# pose mode
<img src="./pose-mode.png">

## reset bones to original pose
- select bone or bones and goto Pose - clear transform -> all or anything
- <img src="./reset-bone-pose.png">

# Armature basic
- shift + a to add armature
- press TAB to switch to edit mode

## select
- click the following or press and drag the mouse onto this
- <img src="./select-bone.png">

## new bone
- to be added in `Edit mode` only

### shift + a
- move the bone to new place
- press shift + a
    - this will automaticaly add another bone at the center

### extrude
- select tail and press `e` to extrude the bone

### subdivide
- select the bone, right click -> subdivide

### scale based on origin
- select bone -> change the mode as shown in the image
- <img src="./scale-bone-wrt-origin.png">
- press `s`

## rename bones
- <img src="./bone-rename.png">
- or press `f2`

### naming convention to symmetrize
- thigh.L
- upperarm.L

## connect bones
- select 2 bones and press ctrl + p
    - keep offset will keep them seperate
    - connect will snap child bone onto the parent

## duplicate other side of bones or symmetrize
- select bones
- right click and select symmetrize
- <img src="./bone-symeterize.png">

# Weights
- weight paint becomes available when mesh is selected
- <img src="./enable-weight-paint-menu.png">

## automatic weights
- switch to object mode
- select the mesh
- press shift and select the armature
- press ctrl + p
- automatic weights
- <img src="./auto-weight-transfer.png">

## weight painter see bones
- select bones -> select mesh -> go to weight paint
- <img src="./visualize-weights-on-bones.png">
- or press alt + z