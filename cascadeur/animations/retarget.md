# Retarget

## copy entire animation to a different armature or rig

- first make sure both the armature are setup for auto pose
  - also the armature bones placement should be nearly same or else the retarget copy/paste will fail
- <img src="./images/retarget-copy-paste.gif">

## move the entire model with animations

- select the root of the model
- goto "Autoposing mode" or "point control mode"
- <img src="./images/retarget/select-root-of-model.png">
- enable 'Trajectory Edit Mode'
- <img src="./images/retarget/enable-trajectory-selct-frame.gif">
- select only the trajectory points
- <img src="./images/retarget/move-model-trajectory-edit.gif">
- move using gizmo

## Rotate the entire model with animations

- make sure the 'curve' is set to step
- <img src="./images/retarget/interval-edit-settings.png">
- <img src="./images/retarget/interval-edit-select-and-rotate.gif">
- select all the points
- select all the frames
- enable rotation gizmo
- enable "Interval edit mode"
- rotate
- disable "Interval edit mode"
