# bevel

<img src="./images/effects-nodes/bevel-node.png">

## positive

pushes the shape from inside to outside

- <img src="./images/effects-nodes/bevel-node-positive.gif">

## negetive

pulls the shape from outside to inside

- <img src="./images/effects-nodes/bevel-node-negetive.gif">

## smoothness

- <img src="./images/effects-nodes/bevel-node-smoothness.png">

## normal map

bevel node outputs a norml map

### normal format

- set to OpenGL
  - `TODO` - find what is required for adobe substance painter material

# vector warp greyscale

- warps the greyscale input details around the normal input
- <img src="./images/effects-nodes/vector-warp-greyscale.png">

## normal format

- set to OpenGL
  - `TODO` - find what is required for adobe substance painter material

# swirl geryscale

## increase mask size

- <img src="./images/effects-nodes/swirl-greyscale-inc-size-cover.png">

## how to swirl

- properties -> instance parameters -> amount

# directional warp

## how to use

- use with a cloud noise to make make jagged lines

# directional scratches

## settings

- angle
- angle random

## application

### scrtaches with dots

- <img src="./images/effects-nodes/directional-scratches-app-1.png">

#### how to use

- <img src="./images/effects-nodes/direcational-scratches-with-noise-n-vector-wrap.png">
- vector map can take the `normal` node output (normal from height node)
- blend mode overlap
