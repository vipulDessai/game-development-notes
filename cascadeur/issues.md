# control points snapping back

- <img src="./images/issues/points-snapping-back.gif">
- the issue is we have moved the track frame, but not added any keyframe
- as we slide the frames, add the keyframe

# Red square on some joints

- <img src="./images/issues/fix-points.png">
- this happens if u press `r`, press `r` again

# After retarget copy / paste, moving any auto pose controls snaps the entire rig

- <img src="./images/issues/auto-pose-snaps-on-move.gif">
- select the points
- lock the auto control points that you need with shift + z
- <img src="./images/issues/set-lock-selected-controllers.gif">
- or this button
- <img src="./images/issues/set-lock-selected-controllers.png">

**Note:** we can also do this for all frames using "Interval Edit mode"

# Exported animation from cascuader does not match the original armature in blender

- <img src="./images/issues/armature-mismatch-issue.gif">
- the model which was exported with a specific `Pose` and armature, when animated and reimported in blender, fails to match its original armature
- fix is always export and import with mesh
- <img src="./images/issues/armature-mismatch-fix.png">

# Slow speed of animations

- do NOT use uncheck `export translate animations` in cascuader, it slows down the animations
  - this [tutorial](https://youtube.com/shorts/NsT2dHwPiwI?si=AriDlxWcL4IGq-TL) recommends it, but keep it enabled
- also make sure the sampling rate in blender is 60FPS
- <img src="./images/issues/fps-issue-in-anims.png">

# in place or in-place animations issues

## Position of the charactor model using it is odd

- <img src="./images/issues/anims-cascauder-extra-root-channel.gif">
- delete the extra channel just below the root channel
  - in the above example its `basic-player`
