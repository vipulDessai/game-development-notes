# **Gimp**

# Settings

## not tools switching

- stop the tools swtiching while switching between mouse and drawing pen
- edit -> preferences → Input Devices
- Look for the option: “Share tool and tool options between input devices”
- <img src="./images/disable-tools-switching.png" />
- Enable this setting

## no pen pressure

- <img src="./images/paintbrush-disable-pen-settings.png" />
- disable this

# Viewport

- rotate - shift + middle mouse and move

## UI

### how to show the tabs

- <img src="./images/open-dialog-window-in-tabs.png" />
- clicking on any will open that window in these tab area

### break aspect ratio etc

- <img src="./images/break-aspect-ratio.png" />
- click this icon to disconnect ratios

## Image

### find the center of the image

- <img src="./images/guides-for-image-center.png" />
- add horizontal and vertical guide

## preview gif files

- Go to Filters → Animation → Playback

# layers

## move all layers (aka linked layers)

- select all layers
- hold shift and move them

### eneble move all layers otherwise

- <img src="./images/move-all-linked-layers.png" />
- enable the optiona and now we can when without pressing shift

## layers modes

- <img src="./images/layer-modes.png" />
  - multiply to darken
  - dodge to lighten

# Selections

## select only the layer content (not the border) or silhouette

- <img src="./images/select-layer-outline.png" />
- hold alt and click on the layer in the layer panel

## path tool

- <img src="./images/path-tools.png" />
- or press b, click and drag

## subject bound path selector (intelligent scissor)

- <img src="./images/fuzzy-0scissor.png" />
- click the points

**NOTE**: you can add more by clicking on the line and dragging it

## fine selection

- after the selection press shift + q
- the selection turns red
- use paint brush (p)
  - white to make more red
  - black to remove
- <img src="./images/fine-selection-mask.png" />
- to exit press shift + q again

## move selection

- in the move tool select "Selection" and then we can move the selection
- <img src="./images/move-selection-with-move-tool.png" />

## save selection as path

- go to paths and "click on selection to path"
- <img src="./images/save-selection.png" />

## convert path to selection

- go to paths and "click on selection to path"
- <img src="./images/path-to-selection.png" />

# Tools

## clear (delete backgroun)

- make the selection
- edit -> clear

## move

### in case curve is displayed on mouse (path move is selected)

- <img src="./images/move-tool-settings.png" />
- select this to move layers properly

## Gradient

- under bucket fill tool

### gradient tool settings

- <img src="./images/gradient-tool-basic-settings.png" />
- highlighted are colors, invert, type, shape, and where to begin from (center of a image)

## Text

- **TIP:** if working with rotated text then use italic
- <img src="./images/rotated-text-italics-good.png" />

### select only the text

- <img src="./images/alt-select-for-text-seelction.png" />
- press alt + click on the layers to select only text
- <img src="./images/save-selection.png" />
- save the selection by converting it to a [path](./gimp.md#save-selection-as-path)

### draw stroke around the text

- you need to have the [selection saved as path](./gimp.md#save-selection-as-path)
- <img src="./images/stroke-the-path.png" />
  - select the path and click on draw along the path

# Effects (filters)

## blur

### gaussian blur

- effects -> blur -> gaussian blur

## long shadows

- <img src="./images/shadow-effect.png" />
- select the layers
- goto filters and "Light and shadow" -> long shawdow
- chose different styles, length, angle and color for customizations

**Note**: if you only want to keep shadow - choose the `Composition` settings

## drop shadows (for hover effect)

### using drop shawdow

- filters -> "Light and shadow" -> drop shawdow

### using long shawdow

- filters -> "Light and shadow" -> long shawdow
- style -> as finite or fading
- <img src="./images/drop-shadow-2.png" />

# colors

## colors desaturate

i.e. remove saturation / remove colors / black and white

- colors -> desaturate -> desaturate

## colors invert

i.e. black to white and vice versa

- colors -> invert

## colors levels

powerful tool for adjusting the brightness, contrast, and tonal range of an image using its histogram

- colors -> levels

# colors curves

add any color to lighter or darkish areas of the image (layer), i.e. selecting a red, green or blue channel will add the color irrespective of perceived color

- graph colors
- <img src="./images/color-curves-graph-reference.jpg" />

## how to add colors to dark or light tones

- select the layer
- go to colors -> curves
- select the channel
- <img src="./images/add-color-dark-light-tone.png" />

# issues

## scaled iamge produces transformation layer

- <img src="./images/extra-layer-on-resize.png" />
- clear the selction
