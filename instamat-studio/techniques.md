# Techniques

# create basic mask to seperate 2 parts of material

- use height blend
  - have top and bottom input be somehow seperated with histogram select (refer `histogram select - inverse greyscale` notes)
- once the base and mask is output from the `height blend`, create 2 nodes from the `output` pin and connect as foreground and background to a blend node
- connect the mask output pin from the `blend height` to the opacity of the blend node
- adjusting the foreground levels will control top portion of `blend height`
- adjusting the background levels will control bottom portion of `blend height`

# inflate the noise texture

<img src="./images/techniques/inflate-effect.png">

<br />

- <img src="./images/techniques/cloud-blur-slope-blur.gif">
- add blur node to cloud noise
- make sure the cloud noise has enough scale
- adjust the slope blur intensity

## applications

- to form mortar

## dry mortar to moist mortar

<img src="./images/techniques/moist-mortar-effect.gif">

<br />

- add the guided blur
- add liquid noise as height
- set a very low intensity on the quided blur
- <img src="./images/techniques/moist-mortar-effect-howto.gif">
- adjust the blend mode if required, to make it intense or subtle

## use levels to inflate more or less overall

<img src="./images/techniques/overall-inflate-deflate.gif">

<br />

- <img src="./images/techniques/overall-inflate-deflate-w-levels.gif">
- use levels node ajustments

# splashes

## simple solid color overlay

- <img src="./images/techniques/simple-texture-splashes.gif">
- use solid color, blend and any type of noise node
- use overlay in blend mode, adjust the opacity

# create a mask only of only flat surfaces

<img src="./images/techniques/select-flat-details-only.png">

## how to create

- <img src="./images/techniques/select-flat-details-only-part-1.gif">
- add `normal to curvature`
- add a blend node to concave (foreground), select the mode to subtract
- add a blend node to convex (foreground), select the mode to subtract
- connect output from `normal to curvature` to concave blend node
- connect output from concave blend node to convex blend node
- <img src="./images/techniques/select-flat-details-only-part-2.gif">
- add the levels node and adjust the levels so to select only the whites
- later this can be used with blend with divide mode
  - whose foreground is non pure white
  - and background is also non pure white

## alternative

- instead of `normal to curvature` and using convex/concave, just use `facing normal` node
- connect it to levels directly and adjust the levels to select only mid whites

# select the edges

<img src="./images/techniques/select-only-edges.gif">

## how to create

- use normal to curvature with radius around 0.17
- use concave output with blend mode subtract, foreground H0 S0 V0.094
- use convex output with blend mode overlay, foreground H0 S0 V0.95
