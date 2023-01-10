## Alt XR FullBody Sample

### Sample structure
    .
    └── Samples
        └── Antilatency XR Integration
            └── <-Package version->    
                └── AltXRFullBodySample
                    ├── Models                          # contains a leg model in .fbx format
                    ├── Prefabs
                    |   └── LegTracking.prefab          # an example of a prepared prefab for leg tracking
                    ├── Scenes
                    |   └── AltXRFullBodySample.unity   # an example of a ready-to-use scene
                    └── Scripts                         # contains several utility scripts

### Sample description

The sample contains a simple scene with the `AltXRRig.prefab` and addition of a leg tracking. 
It is implemented with the `LegTracking.prefab` and Antilatency [Sockets](https://developers.antilatency.com/Terms/Socket_en.html): [Tag](https://developers.antilatency.com/Hardware/Tag_en.html), [Universal Radio Socket](https://developers.antilatency.com/Hardware/Universal_Radio_Socket_en.html) or [Wired USB Socket](https://developers.antilatency.com/Hardware/WiredUSBSocket_en.html). 
They need to be attached to the leg depending on the type of [Environment](https://developers.antilatency.com/Terms/Environment_en.html) you are using:
* in the case of a [Floor tracking area](https://developers.antilatency.com/Hardware/TrackingAreaFloor_en.html), set the Socket to the shin: 

![LegTracking](https://user-images.githubusercontent.com/69207595/200616197-084e4615-2b7b-4d02-b226-7beffa5abcf5.jpg)
* if you are using any other type of Environment, attach the Socket to the foot: 

![FootTracking](https://user-images.githubusercontent.com/69207595/200616164-ac7dbad7-d347-4f26-a1b6-9a709f744b34.jpg)

To set which device will be attached to which foot, write for the device custom `Tag` property the corresponding value: `LeftFoot` and `RightFoot` accordingly (for more information refer to [How to configure device custom properties](https://developers.antilatency.com/HowTo/Set_Device_Custom_Properties_en.html)). 

### Compatibility with Universal Render Pipeline

Samples are compatible with the [URP](https://docs.unity3d.com/Packages/com.unity.render-pipelines.universal@15.0/manual/index.html), however, the materials for the leg model need to be converted. Select them at [Materials](./Models/RoboLeg/Materials) directory and convert it by `Edit -> Rendering -> Materials -> Convert Selected Built-in Materials to URP`.
