# transform location

- in third person character -> event graph
- add get actor transform
- split the reture value
  - connect location to add operator
  - rotation to forward vertor
    - multiply operator (with
      - right click on it and change input to float
        - add value to it
- <img src="./images/tranform-actor-with-rotation.png">

# traces

## line traces from a socket

- add socket to a skeletal mesh
- <img src="./images/add-socket-to-skeletal-mesh.png">
- adjust it
- open the `BP_ThirdPersonCharacter`
- load the charactor class somehow
- <img src="./images/load-static-mesh-variable.png">
- add the get socket transform
  - add the socket name (ex. barrel)
  - split the `value` pin and use the 2 pins (location and rotation)
- add the line trace by channel
- <img src="./images/line-trac-by-channel.png">
  - check trace complex
  - set Draw debug type - for duration
