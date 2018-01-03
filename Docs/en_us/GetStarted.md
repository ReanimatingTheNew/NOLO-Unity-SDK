# Getting Started

## Download NOLO SDK For Unity
* Download [NOLO SDK For Unity](https://github.com/NOLOVR/NOLO-Unity-SDK/tree/master/Downloads) to your local.
## Import to Unity
* Download and Install [Unity](https://unity3d.com),It is recommended to use the Unity5.6.   

* Open Unity,Click “NEW”,Fill in your project name and path.Click “Creata project”,Create a new Unity project.  
<div><img width = 400 heigh = 280 src="https://github.com/LyrobotixNolo/NOLO-Unity-SDK/blob/master/Docs/Image/createunityproject.png"></div>  

  * Click menu Assets->Import Package->Custom Package.  
  
  <div><img width = 400 heigh = 280 src="https://github.com/LyrobotixNolo/NOLO-Unity-SDK/blob/master/Docs/Image/importpackage.PNG"></div>  
  
* Browse to the path for NOLO SDK For Unity and open it.   

<div><img width = 400 heigh = 280 src="https://github.com/LyrobotixNolo/NOLO-Unity-SDK/blob/master/Docs/Image/selectpackage.PNG"> </div> 
<div><img width = 400 heigh = 280 src="https://github.com/LyrobotixNolo/NOLO-Unity-SDK/blob/master/Docs/Image/selectopen.png"></div>  

* Import complete.  

<div><img width = 400 heigh = 280 src="https://github.com/LyrobotixNolo/NOLO-Unity-SDK/blob/master/Docs/Image/importfinish.png"></div>  

## Build Gear VR Example
* Open NoloVR\Example\General\Test. 

* Click File->Build Setting,Click Add Open Scenes,Choose Android and Click Switch Playform.  
<div><img width = 400 heigh = 280 src="https://github.com/LyrobotixNolo/NOLO-Unity-SDK/blob/master/Docs/Image/switch%20playform.png"></div>
* Click Player Settings,Modify Bundle Identifier,Check Virtual Reality Supported and Add Oculus SDK.  
<div><img width = 400 heigh = 280 src="https://github.com/LyrobotixNolo/NOLO-Unity-SDK/blob/master/Docs/Image/playersetting.png"></div>  
<div><img width = 400 heigh = 280 src="https://github.com/LyrobotixNolo/NOLO-Unity-SDK/blob/master/Docs/Image/settings.png"></div>  
* Click build,then install to mobile phone.
<div><img width = 400 heigh = 280 src="https://github.com/LyrobotixNolo/NOLO-Unity-SDK/blob/master/Docs/Image/build.png"></div> 

## Build Daydream Example
* Import [NOLO SDK For Unity](https://github.com/NOLOVR/NOLO-Unity-SDK/blob/master/NoloVR_SDK_1.1.2_20170524.unitypackage)to the same way.

* Open NoloVR\Example\General\Test.  

<div><img width = 400 heigh = 280 src="https://github.com/LyrobotixNolo/NOLO-Unity-SDK/blob/master/Docs/Image/vrcamera.png"></div>  

* Click File->Build Setting,Click Add Open Scenes,Choose Android,Click Switch Playform.  

<div><img width = 400 heigh = 280 src="https://github.com/LyrobotixNolo/NOLO-Unity-SDK/blob/master/Docs/Image/switch%20playform.png"></div>  

* Click Player Settings,Modify Bundle Identifier,Check Virtual Reality Supported and Add Daydream.  

<div><img width = 400 heigh = 280 src="https://github.com/LyrobotixNolo/NOLO-Unity-SDK/blob/master/Docs/Image/playersetting.png"></div>  
<div><img width = 400 heigh = 280 src="https://github.com/LyrobotixNolo/NOLO-Unity-SDK/blob/master/Docs/Image/daydreamsetting.png"></div>  

* Click build,then install to mobile phone.   

<div><img width = 400 heigh = 280 src="https://github.com/LyrobotixNolo/NOLO-Unity-SDK/blob/master/Docs/Image/build.png"></div> 

## Build CardBoard Example
* Import [NOLO SDK For Unity](https://github.com/NOLOVR/NOLO-Unity-SDK/blob/master/NoloVR_SDK_1.1.2_20170524.unitypackage)to the same way.

* Open NoloVR\Example\General\Test.  

<div><img width = 400 heigh = 280 src="https://github.com/LyrobotixNolo/NOLO-Unity-SDK/blob/master/Docs/Image/vrcamera.png"></div>  

* Click File->Build Setting,Click Add Open Scenes,Choose Android,Click Switch Playform.  

<div><img width = 400 heigh = 280 src="https://github.com/LyrobotixNolo/NOLO-Unity-SDK/blob/master/Docs/Image/switch%20playform.png"></div>  

* Click Player Settings,Modify Bundle Identifier,Check Virtual Reality Supported and Add Cardboard.  

<div><img width = 400 heigh = 280 src="https://github.com/LyrobotixNolo/NOLO-Unity-SDK/blob/master/Docs/Image/playersetting.png"></div>  
<div><img width = 400 heigh = 280 src="https://github.com/LyrobotixNolo/NOLO-Unity-SDK/blob/master/Docs/Image/cardboardsetting.png"></div>  

* Click build,then install to mobile phone.   

<div><img width = 400 heigh = 280 src="https://github.com/LyrobotixNolo/NOLO-Unity-SDK/blob/master/Docs/Image/build.png"></div> 


## Other VR SDK
* Drag the helmet preform in SDK to NoloManager->Hmd(camera),Become Hmd(camera)'s child，Reset position and rotation.
* Find NoloVR_Manager.cs from NoloManager,Drag the Camera object that rotation really changes in the game's runtime to VR Camera.
* Other steps reference Gear VR and CardBoard.
