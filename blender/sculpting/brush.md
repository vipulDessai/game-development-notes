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

- <img src="./images/enable-anchored-brush.png">
- switch from the above menu

#### line

- select stroke method as line
- <img src="./images/stroke-method-line.png">
- click and drag the line to draw the pattern

#### anchored

- <img src="./images/what-is-anchored-brush.png">
- use the draw brush
- set stroke method as anchored
- set falloff as sharp
- falloff shape as - sphere
- while drawing press and drag along x, y or z axis

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

## VDM (Vector Displacement Map)

### enable

<img src="./images/enable-vdm-bake-brush.png" />

### Create

- <img src="./images/create-sculpt-plane.png" />
- save
- <img src="./images/save-vdm-brush.png" />
- search
- <img src="./images/vdm-brush-select-search.png" />
- once save the vector image of the brush will be available in the saved project directory in `output_vdm`

### import

- duplicate asset - preffered is `draw` brush
- set the texture
- stroke method to anchored
- set the strength to 1
- <img src="./images/import-vdm-brush-settings.png" />
