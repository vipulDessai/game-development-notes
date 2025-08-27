# **Sculpting**

# setup

## open sculpt mode

- <img src="./images/sculpting-mode-start.png">
- open blender, on the landing pageclick on the sculpting, this gives a sphere

### Or manually

- always start with either cube and subsurface modifier to make it round
- or start with add-on mesh extras -> shift + a -> round cube
- <img src="./images/enable-extra-mesh-add-on.png">
- <img src="./images/add-extras-mesh-round-cube.png">
- goto sculpt mode
- <img src="./images/sculpt-mode.png">
- drag out the brush panel
- <img src="./images/drag-out-brush-panel.png">

**Note**: dont use UV sphere because it has traingles at its top and bottom pole

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
- remesh the mesh with 0.0500 - so that around 10k poly count
- later apply multires - subdivide - 5 - 9M polycount

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

**note** - later use dyno mesh or remesh

## mask

- shift + a
- hold space to adjust
- <img src="./images/selection-by-faceset-or-mask.png">
- press f to invert
- press 2 for different kind of selection (its called falloff)

### open mask menu

- press `a` and move mouse to select the options
- options such as invert, clear, smooth etc
  - increase contrast to darken
  - grow mask to make it cover more area

### diagonal side

- if u drag the shift + a, then 2 and drag from the side, then we can draw mask in diagonal direction
- <img src="./images/mask-gradient.png">

#### make diamond shape

- drag from both corners and add gradient

### mask gradient

- while doing `shift + a`, press b

### loop cut

- while doing `shift + a`, press w, and more w to increase or decrease

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
