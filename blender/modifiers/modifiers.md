# **Modifiers**

## order of modifer

the bottom most modifier will have all the effect of modifiers above ones

- mirror
- subdiv

## view final result preview

- enable the "on-cage" option
- <img src="./images/shrinkwrap-view-final-res-preview.png" />

## vertex group

- select the `mesh` on whose the modifiers will be added
- create a vertex group and assign to the mesh
- <img src="./images/modifier-vertex-group.jpg" alt="modifier-vertex-group" />
- select the vertex group in the modifier
- draw the paint on the `mesh`

## Solidyfy

- <img src="./images/modifier-solidify-description.jpg" alt="modifier-solidify-description" />
- adds thickness to the mesh
- <img src="./images/modifier-solidify.jpg" alt="modifier-solidify" />
- change the `thickness` and the `offset`

## Subdivision Surface

We can smooth the surfaces with these

- <img src="./images/modifier-subdivision.jpg" alt="modifier-subdivision" width="600" />

<b>Note: </b> The faces should have 4 vertices to have loops otherwise the subsurface modifier wont work correctly

### Pull the surrounding of face (Crease)

- select vertices
- Press <kbd>SHIFT</kbd> + <kbd>E</kbd>
- <img src="./images/edge-crease-sub-d.jpg" alt="edge-crease-sub-d" />

### Simple mode

Preserves the corners

- <img src="./images/subsurface-modifier-modes.jpg" alt="subsurface-modifier-modes" />

### Bulid up

- <img src="./images/how-to-get-rid-of-buildup.jpg" alt="how-to-get-rid-of-buildup" width="300" />
- <img src="./images/subdivision-surface-enable-realtime.jpg" alt="subdivision-surface-enable-realtime" width="400" />
- <img src="./images/after-enable-subdivision-surface-realtime.jpg" alt="after-enable-subdivision-surface-realtime" width="300" />

### make flat edges

To create a flat end with subsurface modifier

- press <kbd>SHIFT</kbd> + <kbd>E</kbd>
- <img src="./images/flatten-the-faces-like-no-face.jpg" alt="flatten-the-faces-like-no-face" />

## Mirror

- mirror the mesh arround the origin (of its own or global)
- <img src="./images/modifier-mirror-with-diff-origin.jpg" alt="modifier-mirror-with-diff-origin" />

### Mirror object

- or simply we can use nothing i.e. meshes own origin
- we can select some other mesh whose origin point acts like a mirror
- or we can use `empty object`

## Shrinkwrap

- to flatten a surface of some mesh or stick the mesh to other mesh

- add the target object, select project mode if required
- <img src="./images/shrink-wrap-modifier.jpg" alt="shrink-wrap-modifier" width="500" />

## simple deform

bend any surface around the pivot point

## displace

Create uneven paterns on the mesh

- <img src="./images/what-is-displace-modifier.jpg" alt="what-is-displace-modifier" />
- <img src="./images/modifier-displace-add-texture.jpg" alt="modifier-displace-add-texture" width="500" />
- add the texture and go into texture tools
- <img src="./images/in-texture-select-clouds.jpg" alt="in-texture-select-clouds" />
- select the clouds

### from image

- select the displace type as "Texture"
- head to the texture tab
- <img src="./images/displace-mod-with-img-texture-select-texture.png" />
- select the pattern image
  - should be black and white
- go back to modifiers and adjust the settings
- <img src="./images/displace-mod-with-img-texture-settings.png" />

## bevel

- to add smooth edges to the mesh
- <img src="./images/modifier-bevel.jpg" alt="modifier-bevel" />
- control the thickness
- modify the segments to control the sharpness or smoothness of the edge

### for flat lines

- <img src="./images/modifier-bevel-sideeffects.jpg" alt="modifier-bevel-sideeffects" />
- when bevel is applied the lines edge loops are flattened out
- <img src="./images/modifier-bevel-limit-method.jpg" alt="modifier-bevel-limit-method" />
- apply the above settings
- anything above 60<sup>o</sup> to be beveled (flattened)

## Boolean - for slicing mesh on mesh

- set to `Union`
- <img src="./images/boolean-modifier-settings.jpg" alt="boolean-modifier-settings" />
- set wire view on the slicing reference object
- <img src="./images/boolean-slice-object-property-to-wire.jpg" alt="boolean-slice-object-property-to-wire" />

## Multiresolution

- add this for better sculpting
- <img src="../sculpting/images/multiresolution-modifier-settings.jpg" alt="multiresolution-modifier-settings" />
- click on subdivide to add more resolution

## curve

- have a path whose origin and mesh origin at the same point
- add curve modifier
- <img src="./images/curve-modifier-settings.jpg" alt="curve-modifier-settings" />
- both path and mesh should have origin at same location (ideally at the world origin)
- <img src="./images/curve-modifier-2-obj-origin.jpg" alt="curve-modifier-2-obj-origin" />

## remesh - [refer in sculpting](../sculpting/modifiers.md#remesh)

- used in sculpting or fusing joint mesh (that are joined by ctrl + j)

## decimate - [refer in sculpting](../sculpting/modifiers.md#decimate)

- to lower the poly count
- set the ratio to low value to make a low poly

### edit the path

- select the path
- go into `EDIT` mode
- select the last vertex -> press <kbd>E</kbd> to extrude

### rotate

- select the curve path
- edit mode
- <img src="./images/rotate-in-curve-modifier.jpg" alt="rotate-in-curve-modifier" />
- select the second vertice
- press <kbd>G</kbd> and rotate

### create curves with proportional editing

- <img src="./images/curve-modifier-with-proportional-editing.jpg" alt="curve-modifier-with-proportional-editing" />
- select the bound path
- go into edit mode
- enable proportional editing
- select the tip vertex (last vertex or any other)
- drag it in a direction
