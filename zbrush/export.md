# **Export**

## High poly > 20M

Directly exporting a mesh > 20M is not a standard practice for baking, we need to lower the polycount

- first use zplugins -> decimate master
- process current (the one selected)
  - then wait for the processing
- select the percentage
- decimate current

### settings

- export on visible
- FBX version 2015
- enable Snormals and amount 100%
