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

## settings

- <img src="./images/sculpting-settings.png">
  - front faces - so that to prevent accidental back of the mesh sculpting, which are very close
  - accumulate - each brush stroke will build upon the previous ones

# controls

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

### avoid these

- pen pressure radius
  - <img src="./images/never-set-pen-pressure-radius.png">

# move entire sculpt

## using base pivot

- <img src="./images/base-location.png">
  - or just the selected sculpt

## pivot to unmasked

- <img src="./images/move-only-unmasked-using-pivot.png">
- then select the move
- <img src="./images/move-button-in-sculpt.png">

## Symmetry

- <img src="./images/symeetry.png">

### to enable the symmetry after the sculpting (or transfer the symmetry)

- <img src="./images/enable symmerty.png">

# more vertices

## Remesh - add more vertices (when running out of vertices while drag)

- r and drag the grid to make it finer and left click to set
- to apply this remesh press ctrl + r

**note:** never undo a remeshed object, because blender add more vertices once remeshed again

# Select brushes

- <img src="./images/select-in-sculpt.png">

# Brush

## Stroke

- used to create pattern by pressing down and dragging the brush
  - automatically it sill add the spaces, and no need to tap again and again
- <img src="./images/brush-stroke-spacing.png">

### method

- select stroke method as line
- <img src="./images/stroke-method-line.png">
- click and drag the line to draw the pattern

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

# painting

## use in shading

- <img src="./images/shading-with-sculpting.png">
