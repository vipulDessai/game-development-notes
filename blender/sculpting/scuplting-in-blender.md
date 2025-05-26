# **Sculpting**

# setup

## open sculpt mode

- <img src="./images/sculpting-mode-start.png">
- open blender, on the landing pageclick on the sculpting, this gives a sphere

### Or manually

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

### for better sculpting - add multires modifier - [refer](../basics/blender-basics-notes.md#multiresolution)

- <img src="./images/multiresolution-modifier-settings.jpg" />

#### For better performance

- add subdivision modifier
  - level viewport - 5
  - render - 5
- apply the subdivision
- multiresolution modifier
  - level viewport - 5
  - sculpt - 5
  - render - 5
- dont apply the multiresolution

### shading

- <img src="./images/shading-settings.png">

## viewport settings

### cavity or deep areas

- <img src="./images/sculpt-settings-cavity.png">

### wireframe

- <img src="./images/enable-overlay-wireframe.png">

### control opaqueness of inactive sculpt object

- <img src="./images/fade-inactive-sculpt-objects.png">

## draw straight line

- <img src="./images/draw-line-in-sculting.jpg" alt="draw-line-in-sculting" />

# controls

## switch between object sculpts

- hover over the object
- press alt + q
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

### manually set pivot

- shift + right click

## Selection

- <img src="./images/select-in-sculpt.png">

## face set selection

- shift + w
- hold space to adjust
- <img src="./images/selection-by-faceset-or-mask.png">
- press f to invert
- press 2 for different kinf of selection (its called falloff)

### view hide face sets

- <img src="./images/face-set-visibility.png">

### delete face set

- use the Draw face set brush
- <img src="./images/draw-face-set.png">

## trim or delete

### using face set

- select the face set
- <img src="./images/delete-face-set-selection.png">
- in the sculpt menu -> sculpt -> fair positions
- click on the faceset selection

**note** - later use dyno mesh

## mask

- shift + a
- hold space to adjust
- <img src="./images/selection-by-faceset-or-mask.png">
- press f to invert
- press 2 for different kinf of selection (its called falloff)

### open mask menu

- press `a` and move mouse to select the options
- options such as invert, clear, smooth etc
  - increase contrast to darken
  - grow mask to make it cover more area

# Symmetry

- <img src="./images/symeetry.png">

## to enable the symmetry after the sculpting (or transfer the symmetry)

- <img src="./images/enable symmerty.png">

## transfer symmetry while using multires modifier

- <img src="./images/disable-enable-modifier.png">
- disable the modifier in the modifier section
- then the transfer symmetry will be enabled

# topology (for more vertices and reformating the vertices)

## Dynamic topology

- <img src="images/dynamic-topology-for-sculpting.jpg" />

### constant

- this lets you pick a size using a dropper
- <img src="images/constant-type-dyntope.png" />

## Remesh - add more vertices (when running out of vertices while drag)

- r and drag the grid to make it finer and left click to set
- to apply this remesh press ctrl + r

**note:** never undo a remeshed object, because blender add more vertices once remeshed again

# Brush

## size

### brush size contant on zoom

keep the size of the brush constant on zoom

- <img src="./images/fixed-brush-size-on-zoom.png">

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

## falloff

make the brush either like a ball or like a pipe

- <img src="./images/brush-falloff.png"/>

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

### Grab brush

- press G

#### to not touch or affect sculpt next to the grabbed shape

- <img src="./images/unaffect-others-grab-brush.png" />
- enable "grab silhouette"
- <img src="./images/grab-button-settings.png" />

### smooth brush

- press s to switch to smooth brush
- while using other brush, press and hold shift to use smooth brush

#### invert the smooth brush

- press s to switch to smooth brush
- press ctrl + left click

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

### draw sharp

- to draw creases without pinch and easier than crease smooth or sharp

### clay strips

usually to be used with higher res (remesh 0.008 or like so)

### flatten

use when want to preseve creases but smoothen overall

- <img src="./images/when-to-use-flatten-brush.png">

#### settings

- <img src="./images/flatten-brush-settings.png">
  - more radius more smoothness

### scrape

use to scraps areas like sharp cheeks

- <img src="./images/scrapper-application.png">

#### invert to fill

- <img src="./images/scrape-settings.png">

### fill/deepen

- use with crease brush

#### invert to scrape

- <img src="./images/fill-deppen-settings.png" />

### Density

- can be only used if dyntope is enabled

### pose brush

to move legs, arms like FK

- <img src="./images/edit-using-pose-brush.png"/>

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

# Errors / Issues

## apply scale

- if the brush shape is not round - apply all transforms or scale
- also at the bottom blender will show "object has non uniform scale, sculpting might me unpredictable"
- [solution](../blender.md#object-has-non-uniform-scale)

## pinch not happening properly on high poly mesh
- use bigger size for the brush