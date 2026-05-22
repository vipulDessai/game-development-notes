# Weight Paint

- <img src="./images/weight-painting/weight-paint-add-delete.jpg" alt="weight-paint-add-delete" width="500" />
- reduce weight to have blue
- more weight gives red

# Viewport

## x ray for bright mode

- select the mesh and press <kbd>ALT</kbd> + <kbd>Z</kbd>

## More weight paint layers on object

- <img src="./images/weight-painting/add-vertex-group-for-weight-paint.jpg" alt="add-vertex-group-for-weight-paint" width="500" />

## Show hide the bones above mesh or object

- select armature
- go to `Object Data Properties`
  - the dancing stick man
- Viewport Display
- Select `In Front`

## Select bones while painting

- Go to `object mode`
- Select the bones
- select the mesh
- Go to `weight paint mode`
- <kbd>SHIFT</kbd> + <kbd>CTRL</kbd> + <kbd>Left Click</kbd> on bone to select

**Note:** In case if selection doesnt work then remap the keymap -> 3d view -> weight painting -> select

## stroke -> Stabilize stroke

- if noticing weird weight paint
- in the brush stroke - check if `Stabilize stroke` is ON

## Auto normalize

- to add and subtract so weights are automatically adjusted between multiple vertex groups
- <img src="./images/weight-painting/auto-normalize-setting.png"/>

## overlay

### zero weight or black area

- <img src="./images/weight-painting/overlay-zero-weight.gif"/>

# Paint

## Brush mode

- mix
  - left click to add
  - ctrl + left click to subtract

# Selection

- <img src="./images/weight-painting/selection-modes.png"/>
- paint by selection

## Vertex mode

- press L to select island

# Weight Transfer

## Weight trasfer using data transfer modifier

- <img src="./images/weight-painting/weight-transfer-data-transfer.jpg" alt="weight-transfer-data-transfer.jpg" width="500" />

## weight transfer from selected bones (one or more)

- NO need to create a new vertex group, as a new vertex group will be created
  - if a vertex group is created, select it
- select the bone
- go to "Weight paint menu"
- select "assign automatic from bones"
- <img src="./images/weight-painting/selected-bones-weight-transfer.gif" />
