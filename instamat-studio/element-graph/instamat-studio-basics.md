# **Insta Mat**

# packages

- <img src="./images/basics/manage-packages.gif">
- click on packages
- in the top menu -> File -> new Project

## projects

- packages is parent of projects
- add new projects of type such as element graph, asset texturing etc

# Viewport

## enable 2d or 3d view

<img src="./images/basics/enable-2d-3d-view.png">

## 2d view

### checkboard texture

<img src="./images/basics/enable-disable-checkerboard-in-2d-view.gif">

### image resolution or size

<img src="./images/basics/output-2d-image-resolution.png">

## 3d view

- adjust camera - alt + left click and move move
- adjust light - shift + right click and move mouse

### mesh

- <img src="./images/basics/change-3d-view-rendered-mesh.png">
- ctrl + t

### change env

- ctrl + b

### 3d viewport settings

- <img src="./images/basics/open-viewport-settings.png">

#### height intensity

- <img src="./images/basics/height-intensity-view-settings.png">
- make the "Material AO intensity" to 1

## search

- press space

## multi select

- shift + click and drag

## duplicate

- select the node, alt + click and drag

## alpha or transparency

if the image is NOT a greyscale then it will have a alpha channel

- <img src="./images/basics/alpha-channel.png">

## nodes properties

- <img src="./images/basics/node-properties-basics.png">
- unlock to have a different x and y items
- select the pen to type the value
- select greyscale for using it for drawing patterns

## disable node

- select node and press h, press h to unhide

## drag node connector group

- press ctrl + click on the node connectors and drag
  - in SD its shift + click and drag

## group nodes or frame nodes

- shift + c
  - add title, description and color

## organise nodes

use the reroute image node

- <img src="./images/basics/reroute-node.png">

### how to use reroute image node

- <img src="./images/basics/how-to-use-reroute-image-node.gif">
    - use ctrl and drag the node connectors group

## how to add node in between

- <img src="./images/basics/add-node-on-connector.gif">
- right click and search for the node
- double click to drop the node

## variables

### expose variables

- select the node
- in the properties panel -> right click -> expose

#### expose multiple

- right click node -> expose input parameters
- select the variables -> rename if requred
- hit expose

### exapose variable manually

- <img src="./images/basics/expose-var-attach-manually.gif">
  - create the varible and add type, adjust the more properties
  - drop it
  - drag the pin onto expand and attach to desired pin

**Note**: same way a local variable can be attached

### rearrange output variables

- <img src="./images/basics/rearrange-output-vars.gif">

### resize input / output var name

- <img src="./images/basics/resize-input-var-names.gif">

### rename input variable

- <img src="./images/basics/rename-vars.gif">

### more properties

- <img src="./images/basics/var-more-properties.gif">
- adjust properties such as
  - control -> make it a slider
  - unit -> a custom name that will appear next to variable value

### remove category

- <img src="./images/basics/var-more-prop-remove-category.gif">

# export

- <img src="./images/basics/export-material-menu.gif">
- file -> expoert image and data outputs

## creating template

so that exporting is structured format

`TODO` - notes

## export and use in other projects

`TODO` - how to expose element graph as brush to other projects in the same or different packages
