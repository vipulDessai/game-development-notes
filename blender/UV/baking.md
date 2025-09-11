# Baking

## Create an image for "Baking"

This gives us the UV Map - only after the uv are baked and saved in image file we can edit the UV mesh

- Once the unwrap is done
- go to camera tool
- <img src="./images/baking/create-uv-map-by-baking.jpg" alt="create-uv-map-by-baking" width="400" />
- Bake it to write maps in the file

## select node and UV

- in the `Shader Editor`, select image texture node
- in the `UV Editor` select the image from the above node
- <img src="./images/baking/file-selection-node-and-image.jpg" alt="file-selection-node-and-image" />

## sampling settings

- Render - 32
- Viewport - 32

## Albedo (all colors)

- setting for the Bake engine
- <img src="./images/baking/baking-albedo-bake-settings.jpg" alt="baking-albedo-bake-settings" />

## Normals

- setting for the Bake engine
- <img src="./images/baking/baking-normal-bake-settings.jpg" alt="baking-normal-bake-settings" />

## alpha

- detach the color and set it to white
- make `Emission Strength` to 1.0
- <img src="./images/baking/bake-alpha-BSDF-settings.jpg" alt="bake-alpha-BSDF-settings" />
- setting for the Bake engine
- <img src="./images/baking/baking-alpha-bake-settings.jpg" alt="baking-alpha-bake-settings" />
