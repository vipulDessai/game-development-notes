Unreal Engine Basics

# Performance

- change the settings
- <img src="./images/chnage-global-settings.png">
- disable the volumetric cloud
- <img src="./images/performance-disable-vol-clouds.png">

# project

## start the project with starter content

- while naming the project
- check the "Starter content"

## minimum default map

### chair, table and floor

- <img src="./images/load-min-content.png">

## add the content starter

- <img src="./images/add-starter-content.png">
- in the popup -> content -> select "starter content" -> "Add to Project"

# Editor UI

## basics

- enable framerates
  - ctrl + shift + h

## default settings

- <img src="./images/default-interface.png">

## tabs

- right click and hide it, else click on the blue button
- <img src="./images/tab-hide-show-blue-button.png">

## content drawer

to open press ctrl + space

### filter

- <img src="./images/content-browser-filters.png">

## world settings tab

- <img src="./images/world-settings-tab.png">

# camera

- right click and then the following
- <img src="./images/cam-keys-basics.png">

- right click + z - wider POV
- right click + c - smaller POV

## speed

- <img src="./images/cam-speed.png">
- ritgh click + scroll up or down

## focus on object

- select object
- press f

### rotate around the object

- alt + left click and move mouse

### slowly zoom in\out on the object

- alt + right click and move mouse

# objects

- view object

  - select
  - go to asset management -> double click on the asset

- hide all widgets - press G

- hide/show objects
- <img src="./images/show-hide-widgets.png">

## move, scale, rotate

- <img src="./images/move-rotate-scale.png">

### snap

- movement
- <img src="./images/enable-object-snapping-by-units.png">

- rotate
- <img src="./images/rotate-snap.png">

- scale
- <img src="./images/scale-snap.png">

### snap to another object (object below it or the floor / ground)

- select object
- press end

### lock and move

- <img src="./images/lock-move-axis.png">

## duplicate

- ctrl + d
- drag and duplicate
  - press w to switch to movement
  - alt + click on any axis

### duplicate in a content drawer

- copy and paste there only
- or ctrl + d

## add and drag

- <img src="./images/add-and-drag.png">
    - click and drag where you want to drop the shape

# multiple

- shift + click
- ctrl + click (unselect multiple)

# lock camera while moving

- shift and drag

# Post process

- select post process volume
- <img src="./images/post-process-object.png">
- in details tab
- <img src="./images/details-tab-post-process.png">

## volume settings

- keep post processing within cube or extend it to entire world
  - post process volume settings -> infinte extent
  - this is global illumination ()

## auto exposure

- Lens -> Exposure -> Metering Mode -> Auto Histogram or Auto Basic
  - also enable the Exposure Compensation

## disable game view

- this disables the light exposure
- <img src="./images/game-settings-pov.png">

# level

- file -> new level -> basic level

## open level blueprint

- <img src="./images/open-level-blueprint.png">

# landscape mode (shift + 2)

- refer - https://dev.epicgames.com/documentation/en-us/unreal-engine/landscape-technical-guide?application_version=4.27

- <img src="./images/add-level.png">
- after adding double click on the new level

- switch to landscape mode
- <img src="./images/landscape-mode.png">

- hit create
- <img src="./images/create-land.png">

## lights

### create sky

- add -> lights -> Sky Light, Directional Light
  - Directional Light
    - Details -> Transform -> Mobility -> Movable
  - Sky Light
    - Details -> Light -> Real Time Capture
- add -> Visual Effects -> Sky Atmosphere, ExponentialHeightFog
  - ExponentialHeightFog
    - move the ExponentialHeightFog up or down to inrease / decrease fog

### brush

- select any -> click to draw and shift + left click to deform

## Material

- double click on the meterial (in content drawer) to open the node editor

- right click in any folder of "Content Drawer"
  - add Material
- <img src="./images/add-material.png">

#### Landscape layer blend

- <img src="./images/add-layer-blend-node.png">
- add texture nodes from "Content Drawer" -> Starter Content -> Textures
- <img src="./images/texture-nodes.png">
- press apply

#### adjust sun direction

- press and hold ctrl + l and move the mouse

# packaging

- pack and create executable files
- <img src="./images/pack-project.png">

## Android
- java openjdk 17 for 5.5+
- https://dev.epicgames.com/documentation/en-us/unreal-engine/advanced-setup-and-troubleshooting-guide-for-using-android-sdk

## launch
- follow - [link](https://dev.epicgames.com/documentation/en-us/unreal-engine/setting-up-unreal-engine-projects-for-android-development)
  - setup the phone (enable developer mode and usb debugging)
- <img src="./images/launch-andorid-app.png">
  - package for android and use .bat file
    - ex. `Install_AndroidTpsUnSrcCpp-Android-Shipping-arm64.bat`

<b>Note: </b> The development mode of launching doesnt work, so package and use .bat file to install in the plugged in android phone