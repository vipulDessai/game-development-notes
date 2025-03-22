# Shading
- <img src="select-the-shader-editor.jpg" alt="select-the-shader-editor" />

## minimize/expand node
- <kbd>CTRL</kbd> + <kbd>H</kbd>

## node wrangler 
node wrangler add on lets you see the rendering of the node
- in the preferences enable add on node wrangler 
- <kbd>CTRL</kbd> + <kbd>SHIFT</kbd> + <kbd>Left Click</kbd> on the node

### Shortcuts

#### Mapping
- select the image texture 
- <kbd>CTRL</kbd> + <kbd>T</kbd>

## enable lighting
- lighting helps in seeing the depth effect like the bump
- <img src="enable-render-lights-shader-editor.jpg" alt="enable-render-lights-shader-editor" />

## add material
- Select new object
- Add material
- <img src="shading-new-material.jpg" alt="shading-new-material" width="900" />

## Add new node
- <kbd>SHIFT</kbd> + <kbd>A</kbd>

## group the nodes
- select the nodes
- press <kbd>CTRL</kbd> + <kbd>J</kbd>
- rename in the tool bar
- <img src="group-nodes.jpg" alt="group-nodes" />

## nodes

### input -> object info

### converter -> color ramp
- move the middle slider to the left side to shift the other(left most) color in the middle
- <img src="color-ramp-trick.jpg" alt="color-ramp-trick" />

### texture -> image texture

### Anisotrapic BSDF
Need Cycles
- Shader -> Anisotrapic BSDF

## Combine lines
- <kbd>SHIFT</kbd> and <kbd>Left click</kbd> and drag the mouse over the lines to combine
- <img src="node-combine-lines.jpg" alt="node-combine-lines" />

## Procedural Texturing
- Texture -> Noise texture
- add vecter -> displacement
- <img src="procedural-texturing-layer-1.jpg" alt="procedural-texturing-layer-1" width="900" />
- <kbd>CTRL</kbd> + <kbd>SHIFT</kbd> + <kbd>Left Click</kbd> on the panel `principled BSDF` (main layer)
- View in the render mode

### 2 layers of Procedural Texturing
- add 2 noise texture
- pass one through colorRamp - to darken the 2<sup>nd</sup> noise
- Add them
- Overlay the texture with noise and set the displacement scale very low
- <img src="procedural-texturing-layer-2.jpg" alt="procedural-texturing-layer-2" width="900" />

## Effects

### Gradient
- <img src="gradient-color-mix.jpg" alt="gradient-color-mix" />
- <img src="gradient-effect-nodes-settings.jpg" alt="gradient-effect-nodes-settings" />

### transparency
- <img src="texture-with-gradient-example-for-transparency.jpg" alt="texture-with-gradient-example-for-transparency" />
- connect color to fac of tranparency color ramp 1 
- connect noise texture to Add value 2
- <img src="shader-tranparency-fac.jpg" alt="shader-tranparency-fac" />
- connect transparency color ramp 2 color to fac of Mix shader
- <img src="transparency-shader-to-material.jpg" alt="transparency-shader-to-material" />
- transparency BSDF to shader 1 of Mix shader