# **filter nodes**

# high pass filter

- **Preserves sharp transitions:** like edges, corners, and textures.
- **Removes smooth areas:** such as sky, skin, or blurred regions.
- **Used for sharpening:** often as part of unsharp masking or edge detection.

## example usage with dense noise

 <img src="./images/filter-nodes/highpass-dense-noise-example.gif">

# transform node

- <img src="./images/filter-nodes/transform-node-exmaple.gif">

# levels

- <img src="./images/filter-nodes/levels-levels.png">
- 1 - number black pixels from greyscale image
- 2 - number grey pixels from greyscale image
- 3 - number white pixels from greyscale image

## Adjustments

- move the bottom left slider to right to make image white
- move the bottom right slider to left to remove white from image

# histogram

## select

### inverse greyscale

- <img src="./images/filter-nodes/histo-select-inverse.gif">
- lower the position to zero
