# **Retopology**

## enable Add on

- BSurfaces GPL Edition
- f2
- looptools

## Init B Surface mesh

- <img src="./images/init-bsurface.png" />
- click "initialize"
- <img src="./images/after-ijit-bsurf.png" />

### markings

- <img src="./images/mark-anotations-directions.png" />
    - marking direction is important
- click "Add Surface"
- this add a new mesh "BSurfaceMesh"
  - with shrinkwrap modifier with `target` set to mesh we are retopologising
  - with a subsurface and solidify modifier
    - disable them as needed
  - snapping is on
- auto merge is on - [refer](../basics/blender-basics-notes.md#auto-merge-vertices-or-edges)
- <img src="./images/surfaces-settings-1.png" />
    - enable mirror
    - cyclic cross
    - change faces count by changing "cross" and "follow"

#### make the back surface transparent

- <img src="./images/transparent-backside.png" />
    - goto viewport shading
    - enable backface cuilling

#### shrinkwrap enhancement

- <img src="./images/shrinkwrap-optimization-settings.png" />
    - wrap method -> project
    - enable Negetive

## resume retopology

- select the mesh "BSurfaceMesh" and go to edit mode
- select annotate tool
- draw lines
- in b surface menu -> "Add Surface"

## edit markings

- go to object mode
- select the surface markings
- edit mode

### Erase

- use annotation eraser

### Edit the direction of face

- use scale and flip it

### add more

- <img src="./images/add-more-existing-topo.gif" />
- select the edge where you want more "retopology"
- draw using anotations
- in b surface menu -> "Add Surface"

#### using f2 add on

- <img src="./images/f2-add-on-usage.gif" />
- select the vertice between 2 vertices
- press f and left click to set

### extrude

- in edit mode
- select the edge or vertice
  - press <kbd>e</kbd> + <kbd>left click</kbd> to set
  - or press <kbd>ctrl</kbd> + <kbd>right click</kbd>

### edge loop

- <kbd>ctrl</kbd> + <kbd>r</kbd>
- <kbd>left click</kbd> to set
- move the mouse to position or press <kbd>esc</kbd>

### dissolve edges

- select the edge
- <kbd>ctrl</kbd> + <kbd>x</kbd>

### slide the vertex or edge

- select the edge or vertex
- press double <kbd>g</kbd>

### control edge loop shape using loop tools add on

- select the vertices (usually the loop)
- <img src="./images/loop-tools-usage.gif" />

## Smoothen the topology

- add smooth modifier
- use sculpt -> relax slide brush

## final checks

- after the mirror modifier is applied make sure the joints are merged
- remove the material
