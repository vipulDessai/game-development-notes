# color editor

<img src="./images/color-initial.png">

## add node

- right click on the node
- add node
- serial node

## add alpha output to clip

- **Note:**

  - its better to group the clip as a ["New compound clip"](./edit.md#group-clips-compound), so that the matte and clip timeline are synced
  - otherwise we have to adjust the clips in Davinci edit mode

<br/>

- <img src="./images/color-add-alpha-output.png">
- right click here and select "Add Alpha Output"
- a blue dot will appear below the green dot
- right click on the clip and add matte -> timeline -> `<select your matte from media pool>`
- <img src="./images/color-add-matte-alpha-to-clip.png">

## invert the matte (invert alpha)

- <img src="./images/color-invert-matte-alpha.png">
- select the video clip
- select the rectangle icon (Node key)
- click the key input icons to have desired result

## Primaries - COlor Wheels

- <img src="./images/color-primary-wheel.png">

### change color

- modify the offset

### saturation

- <img src="./images/color-primary-saturation.png">

## HDR

- <img src="./images/color-hdr.png">

### global saturation

- more aware of the scene
- <img src="./images/color-hdr-global-saturation.png">

## Color Graph

- adjust the hue, sat etc based on the colors instead of global setting
- <img src="./images/color-curve-adjustments.png">

### pick the color from video

- <img src="./images/color-use-qualifier-color.png">
- the color picked from the video will be marked on the graph
- adjust the middle dot up or down for color levels

**Note:** right click on dots on the graph to remove them
