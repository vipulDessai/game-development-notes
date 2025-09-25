# sharpen (high pass filter i.e. makes high frequency image)

- rapid changes in intensity (e.g. edges, fine details, noise)
  - A zebra’s stripes = high frequency (black ↔ white rapidly)

## where to use

- good place is just at the end of creating the base color (albedo), just before output node

# slope blur

## settings

- increase the samples
- keep the intensity low like 0.07

## how to use

- can be used with noises like `fractal sum base`, `Gaussian Noise`

# edge detect

- <img src="./images/filter-nodes/edge-detect.png">

# edge wear

its like wears and tears the edges

## how to use

- use normal -> curvature -> edge wear
- use the edge wear as the mask to blend with mode of `soft color`

# curve node

- same as photoshop or gimp node
- <img src="./images/filter-nodes/curve-node.gif">

## add more rings

- <img src="./images/filter-nodes/curve-node-add-more-rings.gif">

## lock while adjusting

- <img src="./images/filter-nodes/curve-graph-node-lock.gif">

# histogram select

use the histogram select as a mask for the blend to select different parts of the material

<img src="./images/filter-nodes/histogram-select.gif">

# gradient map

## gradient editor

- <img src="./images/filter-nodes/gradient-node-gradient-editor.png">
- either double click on the gradient slider
- or click on "Gradient Editor"
- color can be greyscale or any color

# levels

## invert example

- <img src="./images/filter-nodes/levels-node-invert-example.gif">
- drag the white level handle onto the other side and vice versa
