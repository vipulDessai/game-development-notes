# Edit

used for cliping the imported audio and video

## Interface

### switch between animated and source clips

- <img src="./images/edit-switch-animated-to-source.png" />

### zoom timeline

- press alt and mouse scroll

### move frame by frame

- press left or right key

### add markers

- <img src="./images/markers.png" />
- select the video or the audio
- move the slider to the time period
- press <kbd>m</kbd>

### disable clip

- <img src="./images/edit-disable-clip.png" />
- press <kbd>d</kbd>

### group clips (compound)

- select multiple clips
- right click -> new compound clip
- give name and save

### inspector

#### Transforms

- to apply video zoom, rotate, etc
- <img src="./images/edit-transforms-panel.png" />

## key frames

### add key frames

- go to the first frame
- click on the diamond button
- <img src="./images/add-keyframe.gif" />
- it will make the diamond red
- move to another frame
- increase decrease any transform values and automatically it will add the keyframe to that frame

### switch or navigate between next / previous keyframes

- <img src="./images/edit-inspector-switch-keyframes.png" />
    - click the left or the right arrow

**Note:** this can be helpful to remove / delete the keyframes

### reset keyframes

- <img src="./images/reset-transforms.png" />

### keyframe curve editor

fine time key frame animation or transitions, add bezier curve, ease in / out etc

- <img src="./images/open-keyframes-editor.gif" />

## effects

- <img src="./images/effects-menu.png" />

### fusion composition

- <img src="./images/fusion-composition.png" />

**Note**: fusion composition should be small like 2 seconds

#### edit fusion

- select the fusion and go to fusion tab
- <img src="./images/fusion-edit-mode.png" />

#### edit clip fusion

- in order to see the nodes per clip, first slide the timeline onto the clip that you want to view the nodes
- <img src="./images/how-to-select-or-view-nodes-per-clip.png" />
- then click on `fusion`

#### edit opacity

- <img src="./images/edit-fusion-composition-opacity.png" />
- select the fusion clip
- under inspector -> composite -> composite mode
- increase/decrease the opacity

##### composite mode (TODO: learn the difference)

- Luminosity
- Add

## filters

- <img src="./images/edit-add-filter.png" />
- select the fusion clip or any clip that you want the filters
- go to filters
- drag the filter (ex. Guassian Blur) to clip
- now the effects under inspector will appear

## Speed controls

### retime controls (can create timelapse effect)

- right click on the clip
- <img src="./images/retime-controls.png" />
- Retime controls
- move the timeline cursor over the timeline
- click on the arrow next to 100%
- add speed point
- <img src="./images/retime-add-speed-point.png" />

#### increase the speed

- click on the arrow next to 100%
- increase the speed by 400% or anything
- else move the speed point to increase the speed
- <img src="./images/set-speed-time-percentage.png" />
- later adjust the clips
- <img src="./images/speed-a-portion-of-clip.png" />
- once satisfied we can close the retime controls by right click on the clip and click on "Retime Controls"

### freeze the clip

- first split the clip, press <kbd>b</kbd> to select cut tool
- <img src="./images/freeze-first-split-clips.png" />
- right click and Change clip speed
  - enable freeze frame and stretch to fit
- <img src="./images/freeze-change-clip-speed.png" />
- stretch the clips and adjust
- <img src="./images/freeze-change-time-extend.png" />

## link clips or audio or unlink them

- select clips or audio clips
- right click and select "Link Clips" to link even the unlinked
- then again right click and uncheck "Link Clips"

## audio

### remove

- in the edit mode
- when you select the video, the audio is also selected
- right click and click on "Link Clips"
- now both of them are seperated and audio can be deleted by presssing <kbd>Backspace</kbd>
