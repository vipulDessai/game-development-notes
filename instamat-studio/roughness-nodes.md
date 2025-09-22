# roughness

# create roughness map

- create a `normal to curvature` from `height to normal`
- add levels to it
- add output variable with name "Roughness" and type as "ElementImageGrey"
- controlling the levels will result into rough or glossy output on the material
- <img src="./images/roughness-nodes/basic-roughness-node-setup.gif">

## add fine roughness blend with multiple masks

- pick any mask output and add as the foreground for the blend node
- set the blend node to `screen`
- also opacity mask to control the parts of material if required
