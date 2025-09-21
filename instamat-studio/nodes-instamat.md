# **Nodes**

# common

## nodes input

- for input like height etc, we can input noises, also we can input output of other nodes
- <img src="./images/nodes/output-blur-to-output.gif">

# output

## name and type - output property

the name and type is like the usage in substance designer

| Name             | Type             | coversion node              |
| ---------------- | ---------------- | --------------------------- |
| Height           | ElementImageGray | -                           |
| AmbientOcclusion | ElementImageGray | Height to ambient occlusion |
| Normal           | ElementImage     | Height to normal            |
| BaseColor        | ElementImage     | Solid Color                 |

## create variable

- <img src="./images/nodes/output-some-variable.gif">
- give proper name refer the table (name and type table)

## expose as output variable

- <img src="./images/nodes/expose-auto-output-param.gif">

## height conversion

- <img src="./images/nodes/height-to-output-conversion.gif">

# solid color

- <img src="./images/nodes/solid-color-slider.gif">

- S - saturation
- V - Value
- square box - hue

# Flood fill (hand pick shapes of greyscale)

convert black-and-white masks into region-aware data structures

## convert the uv details to mask

use flood fill to mask

- <img src="./images/nodes/flood-fill-to-mask-usage.gif">

### equivalent in substance designer (SD)

- use multiple node to acheive this
  - flood fill to random greyscale
  - histogram scan
  - contrast
