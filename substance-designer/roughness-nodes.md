# roughness

# create roughness map

- add `curvature smooth` from `height to normal` i.e. `normal` node
- add levels to it
  - glossy - if the levels are dark
  - rough - if the levels are white

## how to use

to setup 2 parts material roughness so that both can be controlled individually

- first we need a binary mask
- <img src="./images/roughness-nodes/binary-mask-example--roughness-curve-blend.png">
- use 2 levels node to control each of parts
- <img src="./images/roughness-nodes/basic-2-parts-roughness-setup.png">
