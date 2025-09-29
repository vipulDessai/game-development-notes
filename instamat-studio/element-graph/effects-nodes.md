# transform node

- <img src="./images/filter-nodes/transform-node-exmaple.gif">

# directional warp

control the direction of dripping like effect
<img src="./images/effects-nodes/directional-warp-usage.gif">

## works better with

- 2 layers are merged (blend), like one layer creates brick and second layer is mortar

## settings

- <img src="./images/effects-nodes/directional-warp-settings.gif">
- set direction -> 1
- angle - as required, above example its 270 degree
- trail mode
  - maximum (for extending into the blacks)
  - increase the trail length and lower trail fade
- adjust the intensity

# fractal warp

## works better with

- sloped fractal sum

# guided scatter

- <img src="./images/effects-nodes/guided-scatter.png">

## count

- enable the "mask input" and "scale input" in the node property panel
- <img src="./images/effects-nodes/guided-scatter-count.gif">
- count property increases the density in the of the input shape in the given area limited by the mask
- scale input gradient affects the clutter disttribution

## random color

- <img src="./images/effects-nodes/guided-clutter-shape-random-greyscale.png">
