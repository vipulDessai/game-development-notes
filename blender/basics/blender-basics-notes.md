# **Blender**

# 3D cursor

Drops the new objects over the 3d cursor when they are added in the viewport

- <img src="./images/3d-cursor-enable.jpg" alt="3d-cursor-enable" width="700" />
- <kbd>SHIFT</kbd> + <kbd>Right Click</kbd> - to move it
- <kbd>SHIFT</kbd> + <kbd>C</kbd> - to centre the cursor

## menu

- shift + s
- <img src="./images/view-3d-cursor-menu.png">
    - move to world origin (snap to world origin)

# Origin

The origin is the point which will be attached to the surface of the object on which the particles are added

## menu

- shift + s
- <img src="./images/view-3d-cursor-menu.png">
    - move to world origin (snap to world origin)

## move origin manually

- can be done only in "object mode"
- <img src="./images/move-origin-manually.png">

## set origin to center of a mesh

- Select the object
- <kbd>Right Click</kbd> -> set origin -> origin to geometry
- or
- <img src="./images/set-origin.png">

## transformed pivot point

- set object pivot point to a different reference point
- by default the pivot point is origin (individual origin)

### default

- <img src="./images/default-pivot-point.png">

### set to 3d cursor

- <img src="./images/transformed-pivot-point.png">

# Viewport

## vertices count

- <img src="./images/vertices-count.png" />
- or
- right click on the bottom menu (status bar) -> select "scene statistics"
- <img src="./images/enable-scene-stats.png" />

## panel

- <img src="./images/flip-the-panel-to-bottom-or-top.jpg" alt="flip-the-panel-to-bottom-or-top" />
- <kbd>Right Click</kbd> on the `Object Mode` and `flip to bottom`

## zoom swiftly

- <kbd>CTRL</kbd> + <kbd>Middle</kbd>

## Toggle visibility

- if while importing some mesh from old version are looking as if they are disabled
- <img src="./images/toggle-viewport-visibility.jpg" alt="toggle-viewport-visibility" width="600" />
- also enable the selection and viewport option in filter menu

## Menu

- Press <kbd>N</kbd>

## Change the axis

- <kbd>`</kbd> to open the menu
- Numpad keys
- <kbd>ALT</kbd> + <kbd>Middle Mouse</kbd> + move mouse

## Split the viewport

- <kbd>Right Click</kbd> on the red marking
- <img src="./images/right-click-and-spilt-the-view.jpg" alt="right-click-and-spilt-the-view" width="700" />

## Quad view

- divide the view port in top, front, side and movable viewports
- <kbd>CTRL</kbd> + <kbd>ALT</kbd> + <kbd>Q</kbd>

## Rendered

To see the light on the object

- <img src="./images/view-rendered-object.jpg" alt="view-rendered-object" width="800" />
- or Press <kbd>Z</kbd> and select `Rendered`

## Light

- <img src="./images/enable-lighting.jpg" alt="enable-lighting" width="900" />

### Light settings

- <img src="./images/light-settings.jpg" alt="light-settings" width="900" />

## Change View for the mode (Layout, sculpting, etc)

- Press <kbd>N</kbd>
- <img src="./images/change-view-zoom.jpg" alt="change-view-zoom" width="600" />

## Render Engine

- <img src="./images/render-engine.jpg" alt="render-engine" width="800" />
- can change the render engine to Eveee (For Low graphics ex. games)
- can change the render engine to Cycles (For High graphics)

## Create a image

- Render -> Render Image
- Or Press <kbd>F12</kbd>

## View through the camera

- <img src="./images/view-through-camera.jpg" alt="view-through-camera" width="400" />

## Face orientation

See which face is viewable

- <img src="./images/face-orientations.jpg" alt="face-orientations" width="400" />

## Start Search

- <kbd>F3</kbd>

## Toggle X Ray

- <img src="./images/toggle-x-ray.jpg" alt="toggle-x-ray" width="800" />

## object view (on individual mesh item)

- set a wire view on individual object
- <img src="./images/objects-view-settings.jpg" alt="objects-view-settings" />

## draw marking (annotations)

- press <kbd>D</kbd> and <kbd>Left Click</kbd> and draw with pencil
- to clear the marking open up the menu <kbd>N</kbd> and go to annotation and click on `Subtract` button
- <img src="./images/draw-annotations-with-pencil-tool.jpg" alt="draw-annotations-with-pencil-tool" />

## Images

### Opacity

- <img src="./images/image-opacity-using-alpha.jpg" alt="image-opacity-using-alpha" />

## view region or portion of 3d viewport

- <kbd>CTRL</kbd> + <kbd>B</kbd>
- mark a portion

### exit region view

- <kbd>CTRL</kbd> + <kbd>ALT</kbd> + <kbd>B</kbd>

# Tools

## Object Properties

### render object only for shadows

- so that the blender rendered image will NOT include the additional objects and will only render the main objects shadow
- <img src="./images/shadow-catcher-on-object.png" />

## Tranformation

- <img src="./images/transform-tools.jpg" alt="transform-tools" width="200" />
- <kbd>Left Click</kbd> on the object and tranform it
- <kbd>Right Click</kbd> to reset the tranform

<b>Note: </b> we can switch between the axis while transforming (<kbd>X</kbd>, <kbd>Y</kbd>, <kbd>Z</kbd>) </br>
<b>Note: </b> Press <kbd>T</kbd> for show/hide the toolbar

### Menu

<kbd>SHIFT</kbd> + <kbd>Space</kbd>

### Select inverse degrees

- hit <kbd>SHIFT</kbd> + axis key (<kbd>X</kbd>, <kbd>Y</kbd>, <kbd>Z</kbd>)

### Rotate

- <kbd>R</kbd>
- type the degrees
- or press <kbd>CTRL</kbd> while moving to have 5 degree change

### Move

- <kbd>G</kbd>

#### Moving 2 items without changing the origin

- this helps when using modifiers such as Curve etc
- say suppose we want to move an item which is repositioned in `X` direction
- copy its moved location (<kbd>CTRL</kbd> + <kbd>C</kbd>)
- <img src="./images/move-2-items-without-losing-origin.jpg" alt="move-2-items-without-losing-origin" />
- select both objects
- press <kbd>G</kbd> and press <kbd>X</kbd> for direction
- paste <kbd>CTRL</kbd> + <kbd>V</kbd>

# Object Mode

## Zoom

### zoom to a selection (focus)

- select any point(s)
- press <kbd>NumPad . (dot or numpad delete key)</kbd>

## Add

- <kbd>SHIFT</kbd> + <kbd>A</kbd> to add mesh

## duplicate objects

### different mesh data

- shift + d
  - create seperate vertex group

### sharing mesh data

- <img src="./images/shared-mesh-data-duplicates.png" />
- alt + d
  - two mesh will share the same vertext group
  - useful for sculpting same on both the object

#### seperate the mesh data

- to seperate the mesh data apply the scale
- warning shows up, say "Apply"

## Smooth the object

- select the object by clicking on the object
- <img src="./images/smooth-or-flat-the-object.jpg" alt="smooth-or-flat-the-object" width="600" />

### control the shade auto smooth by angle

- right click and select shade auto smooth
  - adds a modifier automatically
    <img src="./images/smooth-auto-shade.png"/>
- control the smoothness with angle

### Flatten the edges

To smooth everything based on a certain angle

- select auto smooth
- smooth everthing above the angle
- <img src="./images/smooth-the-mesh-flat-property.jpg" alt="smooth-the-mesh-flat-property" />

## Snap or reset the objects at the center

- press <kbd>ALT</kbd> + <kbd>G</kbd>

## Merge or join object

- select the 2 objects
- <kbd>CTRL</kbd> + <kbd>J</kbd>

<b>Note: </b>

- The last mesh origin will be applied to both
- also the one selected first will be one all other that will be merged into
  - i.e name of the first element will be taken like its a parent

### trim off merged parts of the mesh

- go into sculpt mode
- press <kbd>r</kbd> to get the remesh grid
  - make it finer
- enter to set
- ctrl + r to set it

## convert curve to mesh

- <img src="./images/convert-mesh-to-curve.jpg" alt="convert-mesh-to-curve" />

## convert mesh to curve

- <img src="./images/convert-curve-to-mesh.jpg" alt="convert-curve-to-mesh" />

## Apply transform (set transform)

- <kbd>CTRL</kbd> + <kbd>A</kbd>
- <img src="./images/apply-or-set-transform-menu.png" />

NOTE: to make all the transformations as 0, or reset the transformations

# Edit Mode

## change the mouse cursor

<img src="./images/change-drag-icon.png" />

## zoom

### zoom to a selection (focus)

- select any point(s)
- press <kbd>NumPad . (dot or delete key)</kbd>

## Symmetry

- to edit the object so that the vertices on the other axis also are modified
- <img src="./images/edit-mode-symmetry.jpg" alt="edit-mode-symmetry">

## Subdivide

<b>Note:</b> Edit mode should be on

- <kbd>Right Click</kbd> on the object
- Select `Subdivide`

### Increase the smoothness

- <img src="./images/subdivide-smoothness.jpg" alt="subdivide-smoothness" width="600" />

## movement

Switch between transformation orientations of the mesh

- suppose we have a mesh rotated, so while moving the vertices we can avoid global axis and use local
- <img src="./images/move-along-the-local-mesh-axis.jpg" alt="move-along-the-local-mesh-axis" />

<b>Note:</b> while transforming press the axis being locked, press the `axis key` again to switch between global and local.

## Edges

- <img src="./images/select-edge-of-the-object.jpg" alt="select-edge-of-the-object" width="300" />
- To open up the Edge menu
- <kbd>CTRL</kbd> + <kbd>E</kbd>

### Edge Filling (join 2 vertices)

- select the edge and press <kbd>F</kbd> to add a face to part shown in image
- <img src="./images/fill-in-face-using-edge.jpg" alt="fill-in-face-using-edge" width="300" />

### Expand edge

- <kbd>CTRL</kbd> + <kbd>B</kbd>

### draw edge

- <img src="./images/create-a-line-between.jpg" alt="create-a-line-between" />
- press <kbd>J</kbd> to create a staright line between them

#### Delete edge loops (without deleting faces)

- <img src="./images/delete-edge-loops-not-edges.jpg" alt="delete-edge-loops-not-edges" />
- Press <kbd>X</kbd> and select `Edges Loops`

### subdivide the edge

to make a perpedicular out of them

- select the 2 vertices
- <kbd>Right click</kbd> and subdivide

## Vertices

- select 2 points and press <kbd>F</kbd> to make vertex

### Merge

- to get the merge menu
- <kbd>ALT</kbd> + <kbd>M</kbd> or just <kbd>M</kbd>

#### auto merge vertices

- <img src="./images/auto-merge-vertices.jpg" alt="auto-merge-vertices" />

### Merge overlapping vertices

- select the entire mesh or press <kbd>A</kbd> in edit mode
- <kbd>Right Click</kbd> and `merge vertices -> by distance`

### snapping the vertices

To stick the dragging object on the surface, instead of going inside the surface of other selections

- <img src="./images/snap-to-face-of-the-object.jpg" alt="snap-to-face-of-the-object" width="600" />

#### to closest vertex

- <img src="./images/snap-to-closest-vertex.jpg" alt="snap-to-face-of-the-object" />
- and then press <kbd>CTRL</kbd> while moving them to snap to closest vertex

#### to face of other object

- settings below
- <img src="./images/snap-to-face-of-the-object-with-rotation.jpg" alt="snap-to-face-of-the-object-with-rotation" />
- press <kbd>CTRL</kbd> move the object to have the closest rotation of the target mesh face
- <img src="./images/snap-to-face-of-the-object-with-rotation-movement.jpg" alt="snap-to-face-of-the-object-with-rotation-movement" />

### move vertex along the edge (also edges)

- Select the vertex and double press <kbd>G</kbd>
- <img src="./images/move-vertex-along-the-edge.jpg" alt="move-vertex-along-the-edge" />

#### move beyound the original limit

- after double taping <kbd>G</kbd>, hold <kbd>ALT</kbd> or press <kbd>C</kbd> to clamp
- <img src="./images/move-the-vertices-beyond-limits.jpg" alt="move-the-vertices-beyond-limits" />

##### move vertex along the rotated angle

- after clamping (refer above point), move `mouse` left to right
- <img src="./images/shear-operation-move-along.jpg" alt="shear-operation-move-along" />

### align the misaligned vertices

- double tap <kbd>G</kbd> and then press <kbd>E</kbd>
- <img src="./images/edge-slide-align.jpg" alt="edge-slide-align" />

### moving the vertex in a straight line (along its normal)

- select the vertex
- <kbd>ALT</kbd> + <kbd>S</kbd>
- <img src="./images/move-vertex-along-its-normal.jpg" alt="move-vertex-along-its-normal" width="600" />

#### show normal direction

- <img src="./images/display-normal-direction.jpg" alt="display-normal-direction" />

### align along the (X, Y, Z) axis (flatten the vertices)

- <img src="./images/snap-vertices-to-0.jpg" alt="snap-vertices-to-0" width="600" />
- select the vertices
- press <kbd>S</kbd> + (<kbd>Z</kbd>, <kbd>Y</kbd>, <kbd>X</kbd>) + 0

### align along the active element

- select the vertices
- make sure the active elements is selected
- <img src="./images/vertices-align-along-active-element.png" alt="vertices-align-along-active-element" />
- select the vertex which will act like a reference point at which all the previously selected vertices will align to
- press <kbd>S</kbd> + (<kbd>Z</kbd>, <kbd>Y</kbd>, <kbd>X</kbd>) + 0
- press <kbd>ENTER</kbd>

## faces

### make face

- <img src="./images/remove-the-edge-in-between.jpg" alt="remove-the-edge-in-between">
- select the vertices
- Press <kbd>F</kbd>

### delete face

- select the face
- press <kbd>X</kbd>
- <img src="./images/delete-faces.jpg" alt="delete-faces" width="600" />

### Select faces

- <img src="./images/select-faces-of-object.jpg" alt="select-faces-of-object" width="600" />
- then click on the middle of the faces

<b>Note: </b> with face selection pressing <kbd>L</kbd> select one side of mesh easily
<img src="./images/face-select-easliy-with-L.jpg" alt="face-select-easliy-with-L" width="600" />

## Normals

### flip

- will inverse the normals
- to flip, in edit mode menu -> mesh -> normals -> flip

### recalculate normals to the outside

- <img src="./images/when-to-recalc-normals.jpg" alt="when-to-recalc-normals" width="600" />
- Select all vertices
- <kbd>SHIFT</kbd> + <kbd>N</kbd>
- or search for normal recalculations
- or from edit mode menu -> mesh -> normals -> recalculate outside

## Triangles to polygons conversion

- select the faces and go to face
- <img src="./images/faces-tris-to-quads.jpg" alt="faces-tris-to-quads" />
- select the tris to quads

## Extrude

- select vertices
- Press <kbd>E</kbd>

### extrude to cursor

- select the vertex
- move the cursor to a place where you want the extrued to extend to
- press <kbd>CTRL</kbd> + <kbd>Right Click</kbd

## Inset

- select vertices and press <kbd>I</kbd>

### Boundary

- press <kbd>B</kbd>
- <img src="./images/boundary-dissolve-mirror-inset.jpg" alt="boundary-dissolve-mirror-inset" />
- so that the edge near the `mirror side` will dissolve

<b>Note: </b> Make sure there are no faces between the mirror or else the boundary wont work, </br> Below image - 0 is no faces where the `boundary` will work perfectly, 1 is where it wont

- <img src="./images/make-sure-no-faces-between-mirror.jpg" alt="make-sure-no-faces-between-mirror" />

## Creating a bridge between cut faces

- <img src="./images/select-cut-faces-of-object.jpg" alt="select-cut-faces-of-object" width="400" />
- Select cut faces
- press <kbd>F3</kbd> and search for Bridge

## Proportional editing

For editing the vertices near by

- <img src="./images/proportional-editing.jpg" alt="proportional-editing" width="400" />
- Enable it
- select any vertice or vertices
- Press <kbd>G</kbd> and move the object
- <img src="./images/edit-the-vertice-proportionallly.jpg" alt="edit-the-vertice-proportionallly" width="400" />
- Scroll mouse up or down to get the lumpiness

<b>Note: </b> Hide the vertices to avoid proportional editing on non required vertices

### Follow another object

- Atfore joining
- <img src="./images/before-joining-the-objects.jpg" alt="before-joining-the-objects" width="600" />
- Select the parent object
- Then select the child object
- <kbd>CTRL</kbd> + <kbd>P</kbd> and select the `Object (Keep Transform)`
- After Joining
- <img src="./images/after-joining-the-objects.jpg" alt="after-joining-the-objects" width="600" />

## scaling

### from the center of 3d cursor

- <img src="./images/scale-from-center.jpg" alt="scale-from-center.jpg" width="600" />

## Hide

### hide rest

- <kbd>SHIFT</kbd> + <kbd>H</kbd>

## Selection

<b>Note:</b> Edit mode should be on

### enable brush selection

- Press <kbd>C</kbd> and
- Scroll for scaling
- <kbd>Middle Mouse</kbd> to Undo
- <kbd>Right Click</kbd> to disable

### Select the duplicates on the object

- <kbd>SHIFT</kbd> + <kbd>D</kbd> to duplicate the selection
- Select any vertice of the duplicate
- <kbd>CTRL</kbd> + <kbd>L</kbd>

### Seperate the selection

- <kbd>SHIFT</kbd> + <kbd>D</kbd> to duplicate the selection
- Press <kbd>P</kbd> and select the `Selection` option

### All

- <kbd>Left Click</kbd> on the object
- Press <kbd>A</kbd>

### loops

- <kbd>ALT</kbd> + <kbd>Left Click</kbd> the vertex for vertical or horizontal selection of the lines running through the vertex
- <img src="./images/select-loop.jpg" alt="select-loop" width="600" />
- <kbd>CTRL</kbd> + <kbd>I</kbd> to invert the selection

<b>Note:</b> <kbd>ALT</kbd> + <kbd>Left Click</kbd> on the line for vertical selection as shown below

- <img src="./images/alt-loop-selection-vertical.jpg" alt="alt-loop-selection-vertical" />

<b>Note:</b> add loop cut to make the edges sharp

- <img src="./images/add-loop-cut-to-make-them-sharp.jpg" alt="add-loop-cut-to-make-them-sharp" />
- from above to below
- <img src="./images/adding-loop-cut-for-sharp-edges.jpg" alt="adding-loop-cut-for-sharp-edges" />

### Elven - Show the edge

To show the edge its moving along press <kbd>E</kbd>

- <img src="./images/loop-cut-along-the-edge.jpg" alt="loop-cut-along-the-edge" />

#### Flip

- Press <kbd>F</kbd> if the shape is weird

### Hide the selection

- Press <kbd>H</kbd>
- To unhide <kbd>ALT</kbd> + <kbd>H</kbd>

### Extrude the selection

- Select the vertices
- Press <kbd>E</kbd>

### Create a loop on the mesh

- <img src="./images/create-a-loop-on-a-model.jpg" alt="create-a-loop-on-a-model" width="250" />
- Select the model
- <kbd>CTRL</kbd> + <kbd>R</kbd>
- scroll up and down to add more loops or reduce

### Create loop inside a circle

- Select a circle
- Press <kbd>I</kbd> and Drag

### Select only next loop (isolate)

- <img src="./images/select-loops-hide-rest.jpg" alt="select-loops-hide-rest" />
- select a point
- <kbd>CTRL</kbd> + <kbd>NUM +</kbd>
- <kbd>SHIFT</kbd> + <kbd>H</kbd>

### select all by trait

#### non manifold

- <img src="./images/select-eyelashes.png"  />
- like eyelashes in metahuman
- go into x ray mode and unselect rest
- press h to hide
- press alt + h to unhide

## Bevel

- <img src="./images/bevel-operation.jpg" alt="bevel-operation" />
- to create a loop cut only with marked vertices
- <kbd>CTRL</kbd> + <kbd>B</kbd>
- scroll up or down to increase or decrese the loops

<b>Note: </b> Make sure the scale applied and its value is 1

### Add bevel to the vertices

- select the vertex
- <kbd>SHIFT</kbd> + <kbd>CTRL</kbd> + <kbd>B</kbd>
- drag the mouse to see the `bevel`
- scroll up or down to increase or decrese the loops
- <img src="./images/add-bevl-to-90-deg-edges.jpg" alt="add-bevl-to-90-deg-edges" />

### add bevel to edges

- select the edge (press 2)
- ctrl + b and move the mouse

## Shear

when rotating the vertices the height can be affected, use shear instead

- select vertices
- open up search (<kbd>Space</kbd>) and search shear and then select the option
- <img src="./images/shear-operation.jpg" alt="shear-operation" />

## Knife tool

- Press <kbd>K</kbd>
- select any vertex
- Press <kbd>C</kbd> to snap the axis along 45<sup>o</sup>
- <img src="./images/knife-tool-snapping-demonstrations.jpg" alt="knife-tool-snapping-demonstrations" />

## vertex groups

### Assign

- in edit mode, select vertices
- assign
- <img src="./images/assign-vertex-group.jpg" alt="assign-vertex-group" />

### create group from subtraction

- select the group which contain all vertices
- create a new group and assign all vertices from the selected group
- select the group which you want to subtract from the selection
- <img src="./images/select-subtraction-group.jpg" alt="select-subtraction-group" />
- select the new group
- click on `REMOVE`
- deselect everthing and select the new group only

### shape keys

- make sure the shape keys basis is selected and the 'Apply Shape keys in edit mode' is off
- <img src="./images/edit-mode-shape-keys.jpg" alt="edit-mode-shape-keys">

# World environment

- [Download Environment](http://www.hdrlabs.com/sibl/archive.html)
- nodes for the world
- <img src="./images/add-env-to-world.jpg" alt="add-env-to-world" />
- add the Texture -> Enviornment Texture

<b>Note: </b>

- The environment file is .exr extention
- to see the new environment , switch to Render mode

# Adding Material

- <img src="./images/add-surface-material.jpg" alt="add-surface-material" width="600" />
- <img src="./images/add-color-to-surface.jpg" alt="add-color-to-surface" width="600" />

## Material Properties

- Color
- Roughness (glossy to rough)
- Subsurface
  - Radius - R, G, B
  - Color
    - give similar to object color
    - this is when the light goes into the object
    - like the thin layer of skin becomes red as we see it on the bright light
- Transmission - make it 1 for glass
  - to remove the tint the base color should vue should be 1

## Copying material

- Select the object which you want to apply material to
- Select the object which you want to apply material from
- <kbd>CTRL</kbd> + <kbd>P</kbd> and select Materials

### Or select all the objects

- <kbd>CTRL</kbd> + <kbd>L</kbd> and select Materials

### or select from the existing

- <img src="./images/copy-existiing-material-to-mesh.jpg" alt="copy-existiing-material-to-mesh" />
- then create a new material
- selec the old material
- copy using the down arrow
- <img src="./images/select-copy-existiing-material-to-mesh.jpg" alt="select-copy-existiing-material-to-mesh" />
- select the new material
- paste the material

### duplcate material

- add the existing material
- select it and click on button marked 2
- rename it to new name
- <img src="./images/duplicate-materials.jpg" alt="duplicate-materials" />

## water like depth and color

- <img src="./images/water-depth-material.jpg" alt="water-depth-material" width="600" />

## Adding another material

- select the parts or faces of the object
- <img src="./images/assign-second-material-to-same-object.jpg" alt="assign-second-material-to-same-object" width="600" />

# Modifiers

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
- <img src="./images/multiresolution-modifier-settings.jpg" alt="multiresolution-modifier-settings" />
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
