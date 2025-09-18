# **Nodes**

# Output Nodes

## add

- in the graph press "space" -> search for "output"
- <img src="./images/nodes/integration-attributes-panel.png">
- add id and label
- in the "Integration attributes" select its usage

## Properties

### Usage

#### Opacity

whatever is black is hidden, and only white is visible

- <img src="./images/nodes/opacity-node-init.png">
- select the usage as `Opacity`

# Input Node

## uniform color

### Properties

#### change color

controls the detail of the output node

- <img src="./images/nodes/set-uniform-color-white.png">

##### by output

- roughness -> controls reflection
- metallic -> metal

## normal

### properties

#### intesity

make normal details more visible

- <img src="./images/nodes/normal-input-node-intensity.png">

# edge detect

- <img src="./images/nodes/edge-detect.png">

# bevel

<img src="./images/nodes/bevel-node.png">

## positive

pushes the shape from inside to outside

- <img src="./images/nodes/bevel-node-positive.gif">

## negetive

pulls the shape from outside to inside

- <img src="./images/nodes/bevel-node-negetive.gif">

## smoothness

- <img src="./images/nodes/bevel-node-smoothness.png">

## normal map

bevel node outputs a norml map

### normal format

- set to OpenGL
  - `TODO` - find what is required for adobe substance painter material

# vector warp greyscale

- <img src="./images/nodes/vector-warp-greyscale.png">

## normal format

- set to OpenGL
  - `TODO` - find what is required for adobe substance painter material

# blend node

- use to merge different nodes and
- control visibility with black and white with [`curve node`](./nodes.md#curve-node)
- <img src="./images/nodes/blending-node.gif">

## mode

- <img src="./images/nodes/blending-mode-options.png">
    - copy is sharp
    - subtract kind of fuse together
    - multiply 
        - gets rid of white from the foreground
        - overlays black only from background
    - overlay is subtle and smooth like

# curve node

- same as photoshop or gimp node
- <img src="./images/nodes/curve-node.gif">

## add more rings

- <img src="./images/nodes/curve-node-add-more-rings.gif">
