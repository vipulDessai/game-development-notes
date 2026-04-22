# Viewport

## select multiple polygons

- press `alt` and click on multiple polygons
- hold and drag to select more

## proportional edit

- pressing `shift` while doing some actions, kind of does proportional edit
- <img src="./images/what-shift-press-do.gif">

## duplicate

- while dragging a polygroup, pressing `ctrl` seperates it

## assign polygroup color

- while doing the action press `alt`

## repeat last action

- after say inset is set, just click on any other polygon

## delete polygon

- push the polygon inside all the way towards the other side
- <img src="./images/quick-del-poly.gif">

## How to select edges, polygon

- edges - hover over edges
- polygons - hover in the middle of the face (polygon)

# Actions

## insert polyloops

- <img src="./images/insert-edgeloops.gif">

## crease

- creases preserve flatness when the subtool is subdivided
- <img src="./images/what-is-crease.png">

### remove

- alt + click on edges

**Note:** Creases can be added from geometry -> Crease menu

## Qmesh

- the polygons are snapped together
- <img src="./images/what-is-qmesh.gif">
- has all type of mesh targets (poly. quads, etv)
- <img src="./images/actions-n-targets.png">

## Extrude

### merge 2 edges at the center of symmetry

- turn off symmetry
- zmodeler -> press space -> extrude
- <img src="./images/join-2-symm-edges.gif">
- drag the edge and zbrush will auto jon them

### edgeloop

- hover over edge -> space
- target -> edgeloop (instead of edge/edgeloop)

## Inset

### add polyloops

- select action as `inset`
- select target as `polyloop`
- <img src="./images/insert-polyloop-with-inset.gif">

### modifiers

#### Inset Each Poly

- <img src="./images/inset-each-poly.png">

## bridge

### same poly

- click and drag, kind of creates a arc

### seperate poly

- <img src="./images/bridge-seperate-poly.gif">

## Bevel

- <img src="./images/edge-bevel-example.gif">
- edge bevel
- Target - edge complete loop

## Point - Split

- to draw a low poly circle
- <img src="./images/draw-low-poly-circle.gif">

## Point - stich

### join 2 vertices

- <img src="./images/join-2-vertices.gif">
- make sure there are no faces in between
- hover over point -> select action as stich

# Steps (snapping steps)

- press space
- <img src="./images/steps.png">

# Target

## Polyloop

- kinda like edge loop from blender
- <img src="./images/target-polyloop.gif">

## island

- connected polygons - like linked in blender

## polygroup island

- same color polygroup seperated by other polygroup
