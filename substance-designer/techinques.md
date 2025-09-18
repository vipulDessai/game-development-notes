# techniques

## add any pattern only along the edges

<img src="./images/techniques/blending-edge-texture-pattern-result.png">

<hr>
<br />

- <img src="./images/techniques/blending-curve-controls-opacity.png">
- connect bevel normal to `vector warp greyscale`
- <img src="./images/techniques/blending-adjust-bevel-curve-for-edge-texture.gif">
- adjust bevel and curve

## binary fluid pattern using guassian noise

<img src="./images/techniques/fluid-pattern-from-guassian-histo.png">

<hr>
<br />

- for the guassian blur node
  - adjust scale like eg. 10
  - distortion to rotate the texture
- for histogram scan
  - position - more than 0.5 (eg. 0.65)
  - contrast - 1

## make edges jagged with noise

<img src="./images/techniques/make-edges-jagged-with-noise.png">

- add directional warp, increase the intensity, set more than value 1
- <img src="./images/techniques/jagged-edges-directional-warp.gif">

## blending using histgram select

- `TODO`
