# Texturing

## Texture tool

Change its texture pattern

- rename the newly created brush
- <img src="./images/texture-tool-for-sculpt-brush.jpg" alt="texture-tool-for-sculpt-brush" />
- <img src="./images/change-the-texture-pattern.jpg" alt="change-the-texture-pattern" />
- change the color ramp slider (observe the bumpiness in the preview)

## brush texture

- <img src="./images/texture-brush-texture.jpg" alt="texture-brush-texture" />

# Texture Paint

- Add new texture
- save the new texture on the hard drive or <kbd>ALT</kbd> + <kbd>S</kbd> for quick save
- Go to shading and add `texture -> image texture`
- select the neew texture in the node

## issue of brush not working

- after creating the texture
- add a texture node and select the texture
- switch to edit mode and select all the vertices (press <kbd>A</kbd>)
- now the created UV map should be displayed over the newly created texture in the `UV editor`
- now the brush should work while painting on the mesh

## Choose Color

- Press <kbd>N</kbd>
- pick the new color
- Press <kbd>X</kbd> to select

## Texture Mask

- Go to texture mask
- New
- <img src="./images/texture-masking.jpg" alt="texture-masking" width="500" />

### Brush Overlay (darken with same color)

- <img src="./images/texture-overlay-bake.jpg" alt="texture-overlay-bake" width="500" />

## add stencil overlay for brush

- Go to brush -> brush settings -> texture -> `+ New`
- rename (optional)
- click on the `texture tab` button (which takes you to the texture tab)
- <img src="./images/open-texture-tab.png" />
- select `open` -> select the image
- <img src="./images/in-mesh-texture-select-image.jpg" alt="in-mesh-texture-select-image" />
- <img src="./images/image-stencil-overlay.jpg" alt="image-stencil-overlay" />
- go back to brush settings -> mapping -> select `stencil`

### select existing

if the texture is already created for the brush (in brush settings -> textures), then no need to click on the `+ New` button under texture

- go to textures
- select Brush
- <img src="./images/texture-brush-existing-texture.png" />
- select exiting texture
- <img src="./images/texture-brush-existing-texture-select-file.png" />
- now you can go back to brush settings and change texture -> mapping -> stencil (if required)
