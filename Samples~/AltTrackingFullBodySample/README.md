## Alt Tracking Full Body Sample

### Sample structure
    .
    └── Samples
        └── Alt Tracking XR
            └── <-Package version->    
                └── Alt Tracking Full Body Sample
                    ├── Models                                  # contains a leg model in .fbx format
                    ├── Prefabs
                    |   └── LegTracking.prefab                  # an example of a prepared prefab for leg tracking
                    ├── Scenes
                    |   └── AltTrackingFullBodySample.unity     # an example of a ready-to-use scene
                    └── Scripts                                 
                        └── LegSwitcher.cs                      # an utility script for selecting leg tracking configuration

### Sample description

The sample contains a simple scene with the [`AltTrackingXrRig.prefab`](../../Prefabs) and leg tracking. 
It is implemented with the [`LegTracking.prefab`](./Prefabs) and Antilatency [Sockets](https://developers.antilatency.com/Terms/Socket_en.html): [Tag](https://developers.antilatency.com/Hardware/Tag_en.html), [Universal Radio Socket](https://developers.antilatency.com/Hardware/Universal_Radio_Socket_en.html) or [Wired USB Socket](https://developers.antilatency.com/Hardware/WiredUSBSocket_en.html). 
We strongly recommend attaching Socket to the leg in two ways, depending on the type of [Environment](https://developers.antilatency.com/Terms/Environment_en.html) you are using:
* in the case of a [Floor tracking area](https://developers.antilatency.com/Hardware/TrackingAreaFloor_en.html), set the Socket to the shin: 

![ShinPosition](https://user-images.githubusercontent.com/69207595/200616197-084e4615-2b7b-4d02-b226-7beffa5abcf5.jpg)
* if you are using any other type of Environment, attach the Socket to the foot: 

![FeetPosition](https://user-images.githubusercontent.com/69207595/200616164-ac7dbad7-d347-4f26-a1b6-9a709f744b34.jpg)

By default, the leg model is set to the shin position. You can select the desired configuration from the dropdown list of the ['LegSwitcher.cs'](./Scripts/LegSwitcher.cs) script on the [`LegTracking.prefab`](./Prefabs).

To set which device will be attached to which foot, write for the device custom `Tag` property the corresponding value: `LeftFoot` and `RightFoot` accordingly (for more information refer to *[How to configure device custom properties](https://developers.antilatency.com/HowTo/Set_Device_Custom_Properties_en.html)*). 

### Compatibility with Universal Render Pipeline

Samples are compatible with the [URP](https://docs.unity3d.com/Packages/com.unity.render-pipelines.universal@15.0/manual/index.html), however, the materials for the leg model need to be converted. Select them at [Materials](./Models/RoboLeg/Materials) directory and convert it by `Edit -> Rendering -> Materials -> Convert Selected Built-in Materials to URP`.
