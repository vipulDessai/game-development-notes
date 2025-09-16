# smart mask layer (pattern for mask)

- drag and drop the asset to the mask
- <img src="./images/add-mask-pattern.png">
  - the mask pattern appears below the layer details

## create custom smart mask (pattern for mask)

- add `fill layer`
- <img src="./images/fill-for-smart-mask.png">
- disable all except color
  - if we dont want to adjust the shinyness or anything
- <img src="./images/add-genrator.png">
- add a black mask to the `fill layer`
- select the mask
- click on the magic wand -> add generator
- click on generator section and select mask editor
- alt + click on the black mask
- <img src="./images/mask-editor-init-state.png">
- the mask should look like this
- now we can add a material to this
- <img src="./images/add-material-to-fill-layer.png">
- so that only the white portion of the mask will be visible

### modify generator settings

- select the mask
- adjust the curvature
- <img src="./images/genrators-settings.png">
- to soften the edges for the mask

## paint mask editor

- once a mask editor is added, it directly manipulates the mask
- <img src="./images/mask-editor-without-paint-layer.png">
- right click the black mask -> add paint
- <img src="./images/mask-editor-add-paint-layer.png">
- select the mask with alt + click and paint black
- <img src="./images/mask-editor-paint-layer-add-black.png">
- now the material will be gone
- <img src="./images/painting-make-editor-mask-result.png">
