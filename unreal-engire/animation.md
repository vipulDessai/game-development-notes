Animation

# Add

- <img src="./images/add-animation-blueprint.png">
- add the skeletal mesh
- open it and add nodes
- <img src="./images/bp-animation-nodes.png">
- press "Compile"
- add the animation blueprint to the charactor blueprint

# Fix Foot IK (foot position)

- locate the Control rig for the mesh
  - like CR_Mannequin_FootPlant
- open it -> in the "Rig Hierarchy" -> select all bones and right click -> refresh -> select the new mesh
- go to the Anim Graph of the animation blueprint
- between pose history and output pose add the control rig (right click -> misc -> control rig)
- <img src="./images/anim-graph-control-rig.png">

# Animation Sequence

## Edit

- open the animation sequence
- <img src="./images/edit-animation-pose.png">
- reset the animation to first frame
- edit the bones for rotation
- select all the bones in the "Skeletal Tree"
- <img src="./images/animation-seq-add-key.png">
- add key

### show hide bones

- <img src="./images/animation-show-hide-bones.png">
