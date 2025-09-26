# **techniques**

# select only few bricks or scales

<img src="./images/techniques/select-selective.png">

## how to

- <img src="./images/techniques/select-selective-how.png">
- use flood fill -> flood fill to random greyscale
- histogram scan
  - set contrast to full to have binary mask
  - adjust the position to select random
- further improvement
  - can be combined with `blur HQ geryscale` for smoother transitions

# add any pattern only along the edges

<img src="./images/techniques/blending-edge-texture-pattern-result.png">

<hr>
<br />

- <img src="./images/techniques/blending-curve-controls-opacity.png">
- connect bevel normal to `vector warp greyscale`
- <img src="./images/techniques/blending-adjust-bevel-curve-for-edge-texture.gif">
- adjust bevel and curve

## add the colors along the edges or rims

- <img src="./images/techniques/color-only-edges-of-some-shape.png">
- this is the curve node settings for coloring the edges

# binary fluid pattern using guassian noise

<img src="./images/techniques/fluid-pattern-from-guassian-histo.png">

<hr>
<br />

- for the guassian blur node
  - adjust scale like eg. 10
  - distortion to rotate the texture
- for histogram scan
  - position - more than 0.5 (eg. 0.65)
  - contrast - 1

# create cracks using noise

- <img src="./images/techniques/create-cracks-effects.png">
- use `cells 4` noise as foreground and background for a blend node
  - adjust the scale of both of them
  - blending mode is `copy`
- use the above - [`binary fluid pattern using guassian noise`](./techinques.md#binary-fluid-pattern-using-guassian-noise) to create a mask for the blend
- add a `edge detect` and `directional warp` with `clouds 1` noise

# make edges jagged with noise

<img src="./images/techniques/make-edges-jagged-with-noise.png">

- add `directional warp`, increase the intensity, set more than value 1
- <img src="./images/techniques/jagged-edges-directional-warp.gif">

# scratches from tile sampler greyscale

- x ammount - 50
- y ammount - 50
- pattern - paraboloid
- size
  - size
    - x - 0.04, y - 1.29
  - size ramdom
    - adjust as required
  - scale - 3.71
  - scale ramdom -
- Position
  - position random - 3.15
- rotation
  rotation random - 0.23
- color
  - mask random - 0.4
  - color random - 0.4

## additional nodes connection

- swirl greyscale -> rotate
- directinal warp
  - adjust the intensity and angles
- slope blur with fractal base sum
  - <img src="./images/techniques/why-slope-blur-fractal-noise-with-scratches.gif">
    - why to use slope blur with fractal sum base here

# pick details from normal map

- <img src="./images/techniques/normal-details-to-levels.png">
- use curvature to extract details from normal
- use levels to invert or fine tune the details
- use uniform color with blend node to fill the color

# dried color

- <img src="./images/techniques/dried-color-looks.png">

## where its needed

- scales, like the edges or rims of the scales, like a wear and tear effect

## how to create dried color

- <img src="./images/techniques/how-create-dried-color.png">
- use any color that you want to displayed as dried color with blend and blend mode `soft color`
- use normal to curvature and connect curvature node to curvature input of edge wear
- edge wear settings
  - adjust the level, contrast, edge width

# unblur a blur

<img src="./images/techniques/unblur-a-blur.gif">

ofcouse reducing the intensity of blur node does the trick, but for finer tuning use a curve node

## how to

- <img src="./images/techniques/blur-grey-curve.png">
- connect the `blur HQ geryscale` to curve and adjust the curve
