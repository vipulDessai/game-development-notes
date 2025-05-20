# **Sculpting**

# setup

- <img src="./images/sculpting-mode-start.png">
- open blender, on the landing pageclick on the sculpting, this gives a sphere

## Or manually

- always start with a UV Sphere
- <img src="./images/basic-sculpt-uv-sphere.png">
- goto sculpt mode
- <img src="./images/sculpt-mode.png">
- drag out the brush panel
- <img src="./images/drag-out-brush-panel.png">

## assign keyboard keys shortcuts

- right click on the brush tools
- <img src="./images/assign-keyboard-keys.jpg" alt="assign-keyboard-keys" />

## settings

### preferences (basic)

- [refer](../blender.md#settings)

### recommended

- <img src="./images/sculpting-settings.png">
  - front faces - so that to prevent accidental back of the mesh sculpting, which are very close
  - accumulate - each brush stroke will build upon the previous ones

### viewport

#### control opaqueness of inactive sculpt object

- <img src="./images/fade-inactive-sculpt-objects.png">

### shading

- <img src="./images/shading-settings.png">

## view

- <img src="./images/sculpt-settings-cavity.png">

## scale

- if the brush shape is not round - apply all transforms or scale
- also at the bottom blender will show "object has non uniform scale, sculpting might me unpredictable"
- [solution](../blender.md#object-has-non-uniform-scale)

## for better sculpting - add multiresolution modifier

- <img src="./images/multiresolution-modifier-settings.jpg" />

## draw straight line

- <img src="./images/draw-line-in-sculting.jpg" alt="draw-line-in-sculting" />

# controls

## switch between object sculpts

- alt + q
- or press here
- <img src="./images/switch-objects-scuplt.png">

## set space to toolbar or brushes

- open preferences
- <img src="./images/set-space-to-tools.png">

## zooming & pan

- shift + middle mouse for pan
- ctrl + middle mouse for zoom

## Strength & radius

- press F for radius & move mouse up down
  - tap to exit
- press shift + F + move mouse up down for strength
  - tap to exit

## Smooth brush

- hold <kbd>SHIFT</kbd> and tap

## Subtract brush

- hold <kbd>CTRL</kbd> and tap

### avoid these

- pen pressure radius
  - <img src="./images/never-set-pen-pressure-radius.png">

# operations

## duplicates

- [refer](../basics/blender-basics-notes.md#duplicate-objects)

## move

### base pivot (still moves only the unmasked)

- <img src="./images/base-location.png">
  - or just the selected sculpt

### set pivot to unmasked

- move the pivot
- <img src="./images/move-only-unmasked-using-pivot.png">
- then select the move
- <img src="./images/move-button-in-sculpt.png">

## Selection

- <img src="./images/select-in-sculpt.png">

# Symmetry

- <img src="./images/symeetry.png">

## to enable the symmetry after the sculpting (or transfer the symmetry)

- <img src="./images/enable symmerty.png">

# topology (for more vertices and reformating the vertices)

## Dynamic topology

- <img src="images/dynamic-topology-for-sculpting.jpg" />

## Remesh - add more vertices (when running out of vertices while drag)

- r and drag the grid to make it finer and left click to set
- to apply this remesh press ctrl + r

**note:** never undo a remeshed object, because blender add more vertices once remeshed again

# Brush

## Stroke

- used to create pattern by pressing down and dragging the brush
  - automatically it sill add the spaces, and no need to tap again and again
- <img src="./images/brush-stroke-spacing.png">

### method

- select stroke method as line
- <img src="./images/stroke-method-line.png">
- click and drag the line to draw the pattern

## add Texture to brush

- <img src="./images/add-texture-to-sculpt-brush.jpg" alt="add-texture-to-sculpt-brush" />
- add the new texture
- select mapping as `Random`

## types

### mask

- enable - m
- shift - smooth the mask
- invert - ctrl + i
- clear - Alt + M

#### mark vertices that should not be sculpted

- <img src="./images/mark-non-affected-vertices.png">

#### drag and select

- press b and drag to mark it mask

### crease polish

- <img src="./images/pinch-brush-settings.png">
- set Pinch to 0

#### make it sharper

- <img src="./images/crease-sharper-falloff.png">

#### sharper lines

to draw shapes like muscle strands

- <img src="./images/set-stroke-for-crease-brush.png">
  - set 5% spacing and disable `adjust strength`
  - make sure the pinch in the brush details panel (right panel) is 0

### clay strips

usually to be used with higher res (remesh 0.008 or like so)

### flatten

use when want to preseve creases but smoothen overall

- <img src="./images/when-to-use-flatten-brush.png">

#### settings

- <img src="./images/flatten-brush-settings.png">
  - more radius more smoothness

### scrapper

use to scraps areas like sharp cheeks

- <img src="./images/scrapper-application.png">

### cloth brush

- <img src="./images/cloth-brush-tools.jpg" alt="cloth-brush-tools" />
- in the tools, select the type of brush function

#### stroke cloth airbrush

- <img src="./images/cloth-brush-stroke.jpg" alt="cloth-brush-stroke" />

## download new brush

- download from - - [link](https://pixologic.com/zbrush/downloadcenter/alpha/)
- add new brush from texture
- <img src="./images/add-new-brush-texture.jpg" alt="add-new-brush-texture" />
- select image
- <img src="./images/new-brush-settings-sculpting.jpg" alt="new-brush-settings-sculpting" />
- add above highlighted settings

# painting

## use in shading

- <img src="./images/shading-with-sculpting.png">

## Masks (Layers)

- <img src="./images/sculting-layers-masks.jpg" alt="sculting-layers-masks" />

<b>Note: </b> if u cant see the masks (face sets), disable the subsurface modifier

### masks by uv seems

- <img src="./images/masks-by-uv-seems.jpg" alt="masks-by-uv-seems" />
- now we need to use the face masks, we need to enable advanced setting (refer below options)

#### boundary

- preserving the boundary
- <img src="./images/faces-sets-boundary.jpg" alt="faces-sets-boundary" />

#### only one face

- <img src="./images/faces-sets-auto-masking.jpg" alt="faces-sets-auto-masking" />
