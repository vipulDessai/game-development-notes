# UV Editing

**Note:** before beginning please make sure the scale is applied

<img src="./images/uv/select-uv-editor.jpg" alt="select-uv-editor" width="900" />

## UV editor viewport

### Reset UV unwrap

- Select the object you want to reset the UV
- Press <kbd>U</kbd> for UV editing menu
- Reset
- <img src="./images/uv/prepare-uv-reset-all-uv.png"/>

### mark seam

- select the edges -> right click (or press u) -> mark seam

### Enable Heat maps (show stretching)

- <img src="./images/uv/enable-stretching-uv-map.jpg" alt="enable-stretching-uv-map" width="500" />

### Sync Selection - OFF

#### selection mode

- <img src="./images/uv/sync-off-selection-option.png" />

### Sync Selection - ON

- if the sync selection is ON, we can select from the edit mode window (right side window), and this will select individual vertices
- <img src="./images/uv/uv-keep-selection-without-select-all-on-mesh.jpg" alt="uv-keep-selection-without-select-all-on-mesh" width="400" />

## UV unwrap

### create a UV image

this is just a UV checker image

- <img src="./images/uv/new-button-uv-editor.png"/>
- give name like "UV.checker"
- <img src="./images/uv/create-uv-image.png"/>
- <img src="./images/uv/new-uv-checker-ready.png"/>

### map uvs

- first reset the faces (refer above for reset)
- for hard surface do as follows
  - if change the view, which naturally describes the primary feature of the subject (ignore the organic example in the images 😉)
  - <img src="./images/uv/prepare-uv-change-view.png"/>
  - enable the x ray mode (alt + z or from menu)
  - <img src="./images/uv/prepare-uv-toggle-on-xray-mode.png"/>
  - select all the vertices
  - go to UV menu and select "Project from view"
  - <img src="./images/uv/prepare-uv-project-to-view-uv.gif"/>
  - scale and move the mapped UV
  - <img src="./images/uv/prepare-uv-scale-first-mapped-uv.gif"/>
- for organic select the edges -> mark seam using key u -> mark seams

### enable the UV checker image in the material

- <img src="./images/uv/enable-uv-checker-material.gif"/>
- go to shading -> select use nodes -> change the base color to image texture
- select the texture node and press ctrl + t
  - also make sure the add on "Node Wrangler" is enabled
- in the UV editor switch from solid to material mode

**Note:** the texture coordinates are important, otherwise the UV won't show correctly

### mirror seam

- make a selection
- go to select menu and "select mirror"

### Perform UV editing

- select the lines on the object and <kbd>Right Click</kbd> and Mark Seam
- in the UV editor right click and unwrap
  - NOT in the edit mode editor
  - Press <kbd>U</kbd> for UV editing menu and select `Unwrap`
- also we can use the <kbd>CTRL</kbd> + <kbd>E</kbd> edge menu to mark seam

### Aling the edge

align the edges horizontaly or vertically (along X or Y axis)

- <kbd>SHIFT</kbd> + <kbd>W</kbd>
- <img src="./images/uv/uv-edge-align-straight.jpg" alt="uv-edge-align-straight" />

### make two island of same size

- <img src="./images/uv/uv-equalize-size.png" />

## live unwrap

- enable live unwrap
- pin few vertices on ur uv map
- scale rest of the map

## Use multiple uv maps (NOT ideal for substance painter)

**Note:**

- that each uv map should be assigned to a new material
- also substance painter cant have seperate UV Map, even for multiple materials
  - so only the first UV map from UV map side panel will be picked
  - not even the active for rendering
  - <img src="./images/uv/uv-export-settings-substance-painter.png"/>
  - keep like this, i.e. no extra UV map

<br/>
<br/>

- add a new uv map in the side panel of the mesh
- <img src="./images/uv/add-multiple-uv-map.png"/>
- select the map
- <img src="./images/uv/select-uv-map.png"/>
- create a new material - (refer blender basics note - duplcate material)
- go to edit mode and assign faces to this material (refer blender basics note - assign custom faces to material)
- configure shader editor setting for using multiple uv map
  - use `UV Map` node and select the uv map
  - connect the output to `image texture` node
  - connect `image texture` node to base color of `Principled BSDF` node
  - <img src="./images/uv/multiple-uv-map-shader-node-configs.png"/>

## exporting uv map

### pack islands (to save space)

- <img src="./images/uv/uv-pack-islands-menu-option.png" />
- <img src="./images/uv/uv-pack-islands-popup-settings.png" />

### export uvs

- select the map by pressing the <kbd>A</kdb>
- to go menu option `UV` and select
- <img src="./images/uv/uv-map-select-and-export.png" alt="uv-map-select-and-export" />

## Create normal map

### Baking nodes

- select the node where the blender should save the bake to
- do not join the node to diffuse BSDF or the output node
- <img src="./images/uv/baking-nodes.jpg" alt="baking-nodes" />

### bake settings

settings for the creating the normal map from high poly mesh to low poly mesh

- select the mesh u want to have as normal (source mesh)
- select the destination mesh
- <img src="./images/uv/baking-normal-map-ray-distance.jpg" alt="baking-normal-map-ray-distance" width="400" />
- keep the `ray distance` as low but slightyly higher than 0

#### Bug of normal maps with low resolution details

- keep the ray distance to 0.1m when placing the objects exactly overlapping on each others
- reduce the ray distance to 0.05 if the normal map doesnt give enough details

## Error while UV unwrap

- [solution](../blender.md#object-has-non-uniform-scale)
