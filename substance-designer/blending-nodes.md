# blend node

- use to merge different nodes and
- control visibility with black and white with [`curve node`](./nodes.md#curve-node)
- <img src="./images/blend-nodes/blending-node.gif">

## blending modes

**Note:**

- mask is common for all i.e. white is visible and black is removed
- if no mask is attached then full layer is visible

<br />

- copy - default
- subtract
  - lays on top of foreground
  - keeps white and gets rid of black from the foreground onto the background
- multiply
  - opposite of `subtract` mode
  - lays on top of foreground
  - keeps black and gets rid of white from the foreground onto the background
- overlay
  - kind of like detailed transparent glass layer
    - foreground is that glass layer
- divide
  - needs non pure white in the foreground and background
