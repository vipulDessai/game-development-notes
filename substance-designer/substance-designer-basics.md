# **Substance designer basics**

# Create

## new project

- new
- select any template like "Adobe Standard Material"
- search and add output node and set usage as ambientOcclusion
- <img src="./images/basics/basic-setup-control-height-AO.png">
- add ambient occlusion HBAO node
- add histograme range node
- connect it to ambient occlusion hbao and height
- <img src="./images/basics/basic-project-setup.gif">
- set `view in 3d view` for following
  - base color
  - normal
  - ambient occlusion
  - height

**Note:** opening existing projects reset the 3d view, so set the 3d view again using `view in 3d view`

# Viewport

## light

- to adjust light - shift + right click and move mouse

## search

- in the graph press "space"
- <img src="./images/basics/viewport-search-space.png">

## duplicate

- select node
- ctrl + d

## disable node

- select node
- shift + d

## 2d view

### which node to view

- double click on any node

## 3d view

### shape

- <img src="./images/basics/change-output-render-shape.png">

### which node to view

- right click on node -> view in 3d view
- <img src="./images/basics/view-in-3d-view.png">
- select the name of the channel you have right clicked
- <img src="./images/basics/what-to-view-in-3d-view.png">

#### reset and view only one

- right click the channel you which you want alone
- <img src="./images/basics/view-only-one-channel.png">
- select the name of the channel you have right clicked
- <img src="./images/basics/what-to-view-in-3d-view.png">

## connect nodes

- press shift and pull out or plug in the pins
- <img src="./images/basics/pull-out-plug-in-pins.gif">

### search and connect

- select the node press space and drop and node

## group

- <img src="./images/basics/group-nodes.gif">

# enviornment

- <img src="./images/basics/env-settings.gif">

# export

## material

- <img src="./images/basics/publish-material.gif">

## alpha (for substance painter brush)

- <img src="./images/basics/export-alpha.gif">
