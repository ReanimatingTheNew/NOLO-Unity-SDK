# Getting Started

## Download NOLO SDK For Unity
* Download [NOLO SDK For Unity](https://github.com/NOLOVR/NOLO-Unity-SDK/tree/master/Downloads) to local.
## Import to Unity
* Download and install [Unity](https://unity3d.com). It is recommended to use the Unity 5.6.   

* Open Unity, Click “NEW”. Fill in your project name and file path. Click “Create project”. (Creates a new Unity project)
<div><img src="https://github.com/LyrobotixNolo/NOLO-Unity-SDK/blob/master/Docs/Image/createunityproject.png"></div>

  * Click menu Assets -> Import Package -> Custom Package.  
  
  <div><img src="https://github.com/LyrobotixNolo/NOLO-Unity-SDK/blob/master/Docs/Image/importpackage.PNG"></div>
  
* Browse for NoloVR SDK For Unity and open it.   

<div><img src="https://github.com/LyrobotixNolo/NOLO-Unity-SDK/blob/master/Docs/Image/selectpackage.PNG"> </div> 
<div><img src="https://github.com/LyrobotixNolo/NOLO-Unity-SDK/blob/master/Docs/Image/selectopen.png"></div>

* Import complete.

<div><img src="https://github.com/LyrobotixNolo/NOLO-Unity-SDK/blob/master/Docs/Image/importfinish.png"></div>  

## Example: Build Gear VR
* Open NoloVR\Example\General\Test. 

* Click File -> Build Setting, click Add Open Scenes, choose Android and click Switch Playform.  
<div><img src="https://github.com/LyrobotixNolo/NOLO-Unity-SDK/blob/master/Docs/Image/switch%20playform.png"></div>

* Click Player Settings, modify Bundle Identifier, check Virtual Reality Supported and Add Oculus SDK.  
<div><img src="https://github.com/LyrobotixNolo/NOLO-Unity-SDK/blob/master/Docs/Image/playersetting.png"></div>  
<div><img src="https://github.com/LyrobotixNolo/NOLO-Unity-SDK/blob/master/Docs/Image/settings.png"></div>  

* Click build, then install to mobile phone.
<div><img src="https://github.com/LyrobotixNolo/NOLO-Unity-SDK/blob/master/Docs/Image/build.png"></div> 

## Example: Build Daydream
* Import [NOLO SDK For Unity](https://github.com/NOLOVR/NOLO-Unity-SDK/blob/master/NoloVR_SDK_1.1.2_20170524.unitypackage)to the same way.

* Open NoloVR\Example\General\Test.   

* Click File->Build Setting,Click Add Open Scenes,Choose Android,Click Switch Playform.  

<div><img src="https://github.com/LyrobotixNolo/NOLO-Unity-SDK/blob/master/Docs/Image/switch%20playform.png"></div>  

* Click Player Settings,Modify Bundle Identifier,Check Virtual Reality Supported and Add Daydream.  

<div><img src="https://github.com/LyrobotixNolo/NOLO-Unity-SDK/blob/master/Docs/Image/playersetting.png"></div>  
<div><img src="https://github.com/LyrobotixNolo/NOLO-Unity-SDK/blob/master/Docs/Image/daydreamsetting.png"></div>  

* Click build,then install to mobile phone.

<div><img src="https://github.com/LyrobotixNolo/NOLO-Unity-SDK/blob/master/Docs/Image/build.png"></div> 

## Example: Build CardBoard
* Import [NOLO SDK For Unity](https://github.com/NOLOVR/NOLO-Unity-SDK/blob/master/NoloVR_SDK_1.1.2_20170524.unitypackage)to the same way.

* Open NoloVR\Example\General\Test.  

* Click File->Build Setting,Click Add Open Scenes,Choose Android,Click Switch Playform.  

<div><img src="https://github.com/LyrobotixNolo/NOLO-Unity-SDK/blob/master/Docs/Image/switch%20playform.png"></div>  

* Click Player Settings,Modify Bundle Identifier,Check Virtual Reality Supported and Add Cardboard.  

<div><img src="https://github.com/LyrobotixNolo/NOLO-Unity-SDK/blob/master/Docs/Image/playersetting.png"></div>  
<div><img src="https://github.com/LyrobotixNolo/NOLO-Unity-SDK/blob/master/Docs/Image/cardboardsetting.png"></div>  

* Click build,then install to mobile phone. 

<div><img src="https://github.com/LyrobotixNolo/NOLO-Unity-SDK/blob/master/Docs/Image/build.png"></div> 


## Other VR SDK
* Drag the helmet preform in SDK to NoloManager->Hmd(camera),Become Hmd(camera)'s child，Reset position and rotation.
* Find NoloVR_Manager.cs from NoloManager,Drag the Camera object that rotation really changes in the game's runtime to VR Camera.
* Other steps reference Gear VR and CardBoard.
