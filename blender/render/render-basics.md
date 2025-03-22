# Render - Create images of the 3d objects

## Transparent background
- under camera
    - render engine - select "Eevee" or if "Cycles" then GPU compute
    - Film - enable "Transparent"
- <img src="transparent-images-render.png">

## Layers
- to control multiple type of views
- <img src="layers-render-multiple-type-of-settings.png">
0. select render engine as "cycles" (or "Eevee")
1. add layer
2. add name
3. modify the view settings under "outliner"
    - Enable or disable `bounced arrow` to only render shadows (works only with "Cycles")
4. Select Film -> "transparent"
5. Get the desired result
    
## sharpen up the shadows in evee
- camera settings
- <img src="set-high-res-shadows-in-camera.png">
- light element settings
- <img src="set-light-element-shadows-bias.png">

## shadow catcher in cycles
- <img src="shadow-catcher-setting.png">
- select the object that you want to have shadows on
- under "object properties" -> Visibility -> Shadow Catcher
- under "Outliner" select indirect lighting (bounced arrow) to hide
    - the object whose only shadows we want in the layer

## Render image with layers

### Cycles and GPU Compute
- under "Render Properties" and "outilner"
- <img src="camera-settings-render-layer.png">
- create a layer with only object fully visible and shadows catching object with indirect lighting (hiding it😅) 
    - in the image its "box" layer
- create another layer with only shadows caught on the shadow catcher object
- <img src="object-properties-render-layer.png">
    - the layer name is "box-shadows"

#### Render image or animation
- <img src="render-option-menu.png">
- go to render -> render image or render animation