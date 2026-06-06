# Substance Painter

basically like a photo shop, where we put layers onto each other and mask it
<br />
<img src="./images/sp-basics.png">

- delete the layers to clear that paint

# Project

## Create

- <img src="./images/new-project.png">
    - select fbx file
    - select texture to 4k
    - if there are texture, select it using import baked maps
    - press okay

## remove paint

- delete the layer from `Layers`

## export

- file -> export textures
- <img src="./images/export-textures.png">

# Viewport

- <img src="./images/drag-asset-for-clear-options.png">
    - drag and expand the penel to see the all asset option instead of filter

# shortcuts

## viewport

- f1, f2, f3

## move, rotate, zoom

- rotate - alt + left click and move
- zoom - alt + right click and move
- move - ctrl + alt + left click and move

## adjust light

- shift + right click

## bake

- press b to cycle through maps
- press m for material map

## invert color

- x

# texture

- <img src="./images/object-textures.png">

## add transparency

- select texture from the texture set list -> shader settings -> select shader as `pbr-metal-rough-with-alpha-blending`
- <img src="./images/textures/shader-with-alpha.gif">
- add opacity settings -> from texture set settings
- <img src="./images/textures/shader-add-opacity.gif">
- enable opaicty for the layer
- <img src="./images/textures/enable-opacity-for-layer.gif">

### Export with transparency

- use the output template - PBR Metallic Roughness
  - this has the base color with aplha merged together
- <img src="./images/textures/export-settings-for-opacity.gif">

# Geometry Mask

- click on the mask button to hide rest of the texture set
- <img src="./images/geomtry-mask-feature.png" >
- click on the brush to view all
