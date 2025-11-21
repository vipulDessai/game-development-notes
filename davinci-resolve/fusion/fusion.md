# Fusion

## Nodes

<b>Note:</b> keyboard shortcut

- press <kbd>SHIFT/CTRL</kbd> + <kbd>SPACE</kbd>
  - to bring up menu to select all types of nodes
- pressing <kbd>SHIFT</kbd> and dragging the node will snap it out
- pressing <kbd>SHIFT</kbd> and dragging the node over a line will attach it to other nodes

### arrange node snapping to grid

- <img src="./images/arage-node-snap-to-grid-cell.png" />

### add connected nodes

- select the node
- <kbd>SHIFT</kbd> + <kbd>SPACE</kbd> and add another node
- automatically the new node is attached to previously selected node
- <img src="./images/connect-nodes.png" />

### grouping

- <img src="./images/group-nodes.png" />
    - select nodes and press <kbd>SHIFT</kbd> + <kbd>SPACE</kbd>
    - search for `Underlay`
    - select it to have a box for the selected nodes

### Detach nodes

- <img src="./images/detach-nodes.png" />
    - click on the blue line

### Merge node

- <img src="./images/merge-node.png" />
    - merges other nodes

<b>Note:</b> another way of adding the merge node to another node is connect the point 1 with the point 2 in the below image

- <img src="./images/add-merge-node-by-connecting-dots.png" />

### underlay

- for grouping the nodes
- <img src="./images/underlay_example.png" />

<b>Note:</b>

1. for moving the underlay only press <kbd>ALT</kbd> and select the `underlay box`
2. now to rename it after selection press <kbd>F2</kbd>

## Grouping

- select all the nodes that you want to group
- press <kbd>CTRL</kbd> + <kbd>G</kbd>
- <img src="./images/group-nodes-shortcut.png" />
- to expand double click the group
- <img src="./images/expand-group-nodes.png" />

## Mask

- <img src="./images/intro-to-mask.png" />
    - allows to select portion of the video to control the merged node
- <img src="./images/mask-node-and-drag-mask.png" />
    - ellipse1 is the mask node 
    - and using the handler we can drag the blur portion for the video
- Mask with merge
  - <img src="./images/mask-node-with-merge-text-node.png" />
  - attaching a mask to merge node, limits the merged portion only (i.e. the text node in the example)

## viewers

- <img src="./images/viewer-example.png" />

<b>Note:</b> keyboard shortcut

- select the node and press <kbd>1</kbd> or <kbd>2</kbd> to assign the node to viewer 1 or 2

## shapes

### enable border only

- <img src="./images/fusion-make-shape-border-only.png" />
- uncheck solid to make it border only

### draw traingle

- use polygon node
- click on the screen
- <img src="./images/fusion-draw-triangle.png" />
- click here and connect the dots
- click on polygon and move it using the arrows

## matte

### create and animate pattern

- add two background merged together
- <img src="./images/create-pattern-fusion.png" />
- select one background and make it white
- other make the alpha to zero (so that its transparent)
- <img src="./images/pattern-fusion-property.png" />
- to the white background add some shapes
  - example some rectangles
- select the rectangle and make sure the frame is 0
- add one keyframe
- <img src="./images/add-keyframe-pattern-fusion.png" />
- move to frame 10 or more and drag the shape to a new place
- <img src="./images/move-pattern-to-animate-fusion.png" />
- repeat to animate more

### export matte

- go to deliver
- under custom export
- select
  - render as individual file
  - codec - `DNxHR`
  - check export alpha
- in the timeline panel
  - select render "in/Out range"
  - and drag the time line to start and end of the fusion
- click on "Add to render queue"
  - this might ask to select the folder, where the .mov file will be saved on the drive
- under render queue, select and render the job
- <img src="./images/export-matte-fusion.png" />

### import matte

- in the media tab, locate the video on the hard drive
- <img src="./images/import-video-as-matte.png" />
- right click and "add to media pool as matte"
- <img src="./images/imported-video-as-matte.png" />
- now the imported media in the pool will have this icon on it

## Expose or reusable fusion

### as nodes

- <img src="./images/fusion-save-node-settings.png" />
- select the nodes, right click -> settings -> either save all as or save as
- this creates .setting file that can draged and droped in the davinci fusion to get the nodes

### as macros

this will hide the nodes and create a single node and that cant be edited

- right click on the node and go to macro -> create macro
- <img src="./images/macro-select-node.png" />
- give name and check box the ones that you want to expose in the macro
- <img src="./images/macro-select-node-settings.png" />
- save it -> click on the 3 dots above
  - it saves it as \*.setting
  - later we have to move it to `C:\Users\<user name>\AppData\Roaming\Blackmagic Design\DaVinci Resolve\Support\Fusion\Templates\Edit\Titles`
    - create the folder if it doesnt exist
  - restart the davinci
- you should be able to see it in effects
- <img src="./images/macro-in-efffect-lib.png" />
