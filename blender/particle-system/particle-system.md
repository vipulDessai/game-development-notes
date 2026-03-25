# Particle system

## Add new particle

- add a mesh and select it
- <img src="./images/add-new-particle-and-hair.jpg" alt="add-new-particle-and-hair" />

## viewport

### canvas movement

- dont click on particle and pan or rorate view
- instead click on parent mesh and move the viewport

## Viewing settings

### render mode divisions or segments

- <img src="./images/render-steps.jpg" alt="render-steps" />

### viewing shading steps

- more steps meaning more sub surface division
- <img src="./images/viewing-shading-steps.jpg" alt="viewing-shading-steps" />

## Children particles

- <img src="./images/children-simple-vs-interpolated.jpg" alt="children-simple-vs-interpolated" />

### Clumping

- settings under particle ->children -> clumping
- <img src="./images/clumping-settings.jpg" alt="clumping-settings" />
- <img src="./images/clumping.jpg" alt="clumping" />

### Roughness

- adjust random and size
- threshold - to control how many strands will be affected by roughness setting
- <img src="./images/roughness-to-control-shape.jpg" alt="roughness-to-control-shape" />

### kink

- have a sine wave in your hair
- <img src="./images/kink-for-shape-sine-wave.jpg" alt="kink-for-shape-sine-wave" />

### Hair shape

- control size of each hair
- <img src="./images/hair-shape-settings.jpg" alt="hair-shape-settings" />
- <img src="./images/each-hair-shape.jpg" alt="each-hair-shape" />

## Particle edit mode

- select the number of segments and number of hairs
- seed - random distribution and positioning of the strands

### move, rotate, scale

- <kbd>G</kbd> - Move
- <kbd>R</kbd> - Rotate
- <kbd>S</kbd> - Scale

### move many hairs/particle with root

- <img src="./images/move-root.gif" />
- enlarge the brush
- disable the preserve root positions

### snap the hair on surface

- <img src="./images/snap-hair-on-skin.gif" />
- select -> roots
- disable preserve roots position
- enable snap
  - face project (or face)
  - align rotation to target, backface cuiling
  - move, rotate & scale
- press g and carefully move mouse with shift and click

### Increase hair length

- <img src="./images/extend-hair-length.jpg" alt="extend-hair-length" />

### Selection mode

- tip selection or mid point selection
- <img src="./images/number-hair-strands-bend-points.jpg" alt="number-hair-strands-bend-points" />

### Tools property

- preserve root
- extend the hair
- avoid clipping root
- <img src="./images/preserve-hair-root-editing.jpg" alt="preserve-hair-root-editing" />

### have fine hair curves

- set Tool -> Options -> Viewport Display -> Path Steps -> 6
- <img src="./images/move-vertices-with-hair-curve.jpg" alt="move-vertices-with-hair-curve" />

### show children hair in particle edit mode

- <img src="./images/show-children-hair-in-edit-particle-mode.jpg" alt="show-children-hair-in-edit-particle-mode" />

### Add

- <img src="./images/add-hair.jpg" alt="add-hair" />

### select roots

- press <kbd>SPACE</kbd> for search in blender
- type select roots

### select next set of vertices

<kbd>CTRL</kbd> + <kbd>NUM +</kbd>

### subdivide vertices

- <img src="./images/subdivide-hair-vertices.jpg" alt="subdivide-hair-vertices" />
