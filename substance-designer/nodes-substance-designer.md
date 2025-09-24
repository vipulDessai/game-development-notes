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

# Flood fill (hand pick shapes of greyscale)

- convert black-and-white masks into region-aware data structures
- the input should have defined edges i.e. the details should not be too smooth or low frequency

## flood fill to gradient

allows to control the gradient of each item seperated using `flood fill`

- <img src="./images/nodes/flood-fill-gradient.gif">

### applications

- could be used to create overlapping grid
- <img src="./images/nodes/flood-fill-to-overlap-grid.png">
