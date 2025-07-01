# Fusion

## Nodes

<b>Note:</b> keyboard shortcut

- press <kbd>SHIFT</kbd> + <kbd>SPACE</kbd>
  - to bring up menu to select all types of nodes
- pressing <kbd>SHIFT</kbd> and dragging the node will snap it out
- pressing <kbd>SHIFT</kbd> and dragging the node over a line will attach it to other nodes

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

## Replace green screen

### Delta keyer

- <img src="./images/delta-keyer-to-replace-green-screen.png" />
- drag the color picker over the green color to replace it
- then drag any media and merge it as `background`
  - and the delta keyer should be `foreground`
- <img src="./images/connection-for-delta-keyer-and-media.png" />
