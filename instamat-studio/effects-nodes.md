# blur node

removes any high frequency noise - TODO - find what is that?

# slope blur

for distorting greyscale's image white portion

## sample count (quality)

- from 16 to 32

## intensity

- controls the mode effect and input from height or direction

## modes

- <img src="./images/effects-nodes/slope-blur-node-modes.png">
    - avg - extends into black
    - min - extends black into white, shrinking the white
    - max - extends more into black

# guided blur

## works better with

works better with liquid noise

# directional warp

control the direction of dripping like effect
<img src="./images/effects-nodes/directional-warp-usage.gif">

## works better

- 2 layers are merged (blend), like one layer creates brick and second layer is mortar

## settings

- <img src="./images/effects-nodes/directional-warp-settings.gif">
- set direction -> 1
- angle - as required, above example its 270 degree
- trail mode
  - maximum (for extending into the blacks)
  - increase the trail length and lower trail fade
- adjust the intensity
