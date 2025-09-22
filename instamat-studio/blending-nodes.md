# blend node

# swap inputs (foregroud and background)

- <img src="./images/blend-nodes/swap-input-blend-node.gif">

# blending modes

## divide

divides the non white background colors by the non white foregroud colors

<br />

<span style="color: red;">IMPORTANT</span>:

- input greyscale pattern should have grey color bricks or pattern
- as the pattern is not shown on white
- same for greyscale and non greyscale nodes

<br />

- <img src="./images/blend-nodes/blend-mode-divide-result.gif">

### how to use

- <img src="./images/blend-nodes/setup-blend-mode-divide.png">
- lower the opacity (eg. 7)
- make sure both the foreground and background has some non white component, otherwise there will be NO visible changes
  - same for greyscale and non greyscale nodes

## invert mask

inverts the opacity mask

- <img src="./images/blend-nodes/blend-node-inverse-mask.gif">

# blend height node

has a output mask, that seperates the input top and bottom

- <img src="./images/blend-nodes/blend-height-node-offset-adjustments.gif">
