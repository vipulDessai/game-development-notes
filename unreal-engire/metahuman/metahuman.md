# metahuman

## enable

- metahuman core
- in the content browser create metahuman character instance
  - right click -> metahuman -> metahuman character asset
- rig, download textures, assemble (this creates the blueprint)

## Export Mesh (USDC workflow)

- locate skeletal mesh body and head
- right click on the skeletal mesh (body)
- export as \*.usdc
- <img src="./images/export-mh-574-usdc-settings.png">
- import the head and body
- go to edit mode -> rename the material (press select in material panel to highlight vertices)

### fix for black eyes

- locate the eye material
- in principle BSDF lower the alpha to 0

## edit in blender

### basic face edit (retain the bones)

- import the converted .fbx
- <img src="../basics/images/add-shape-key-twice.png">
- select the "Body"
- add 2 shape keys (Basis and New Key)
- set the Value to 1
- for face add only 1 key
- set the Value to 1
- <img src="../basics/images/hide-metahuman-face-bones.png">
- hide the bones and the uncheck select bones as well

### advanced face editing

- import the converted .fbx
- select the Face.001 mesh
- alt + p -> clear parent and keep transformation
  - so that the mesh do not resize
- remove the armature modifier
- delete all vertex group and shape keys
- delete materials (click on the -ve button)
- to remove the eyelashes
  - in edit mode and in its menu
    - select -> select all by trait -> Non Manifold
      - go into wireframe and x ray mode and unselect all other vertices apart from lashes
- delete eye ball and mouth
- add subdivision modifier and level as 2 and render as 2 and apply
- do add features
- and import as fbx with mesh only

## export to unreal

- export both face and Body seperately

<b>Note: </b> do not change the vertex count and export and later import in the unreal, this can cause even breaking of all the other metahumans even the core ones

### face

- <img src="./images/rename-face-armature.png">
- rename both to be root and then ONLY export
- select root (group) and rotate along x axis to 90
- <img src="./images/select-metahuman-face-for-export.png">
- select first root (group) and then `Face.001` and then export
- after export immediate do undo (ctrl + z) to restore auto rotate
  - here the blender might freeze, so undo then wait then undo and repeat

### body

- rename `root.*` to root (as blender will add .001 suffix)
- no need to rotate anything
- select first root (group) and then `Body.001` and then export

### export settings

- <img src="./images/metahuman-export-settings.png">
- Include
  - Limit to "Selected Objects"
  - Object Types
    - Aramature and Mesh
- Armature
  - uncheck "Add Leaf Bones"

### import to unreal

- duplicate Main BP\_\* metahuman blueprint class
- duplicate body and face skeletal mesh class
- open the duplicated body skeletal mesh
- under asset details -> import settings -> Asset import Data -> file path -> source file -> ... -> set the path of .fbx exported from blender
- <img src="./images/reimport-mesh-from-file.png">
- click on "Reimport Mesh" options -> Reimport Mesh with new file -> selected exported file from blender
- click on the Reimport Mesh with dialog
- <img src="./images/reimport-mesh-with-dialog.png">
- check import morph targets
- <img src="./images/morph-target-preview.png">
- the new shape key will appear in the morph target preview tab
