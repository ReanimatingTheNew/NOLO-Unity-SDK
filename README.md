# NOLOVR SDK For Unity
Use this SDK to develop nolo compatible moblie VR/AR games with Unity.  

For first time users, see the [Getting Started](./Docs/en_us/GetStarted.md) ([快速入门](./Docs/zh_cn/快速入门.md)).  

APP can run in any Android device,include mobile phone or all-in-one device.  

For example:
- [Gear VR](https://github.com/NOLOVR/NOLO-Unity-SDK/blob/master/Docs/en_us/GetStarted.md#build-gear-vr-example)
- [Daydream](https://github.com/NOLOVR/NOLO-Unity-SDK/blob/master/Docs/en_us/GetStarted.md#build-daydream-example)
- [Cardboard](https://github.com/NOLOVR/NOLO-Unity-SDK/blob/master/Docs/en_us/GetStarted.md#build-cardboard-example)
- [Other](https://github.com/NOLOVR/NOLO-Unity-SDK/blob/master/Docs/en_us/GetStarted.md#other-vr-sdk)

If you have problems,Check [FAQ](https://github.com/NOLOVR/NOLO-Unity-SDK/issues).  
## For developer
* It is important to add the double click system button to reset camera's yaw.  
such as:  
Gear VR:InputTracking.Recenter();  
Cardboard:GvrViewer.Instance.Recenter();
* about application icon  
We would like to be able to add an icon on the app icon,Indicates support for nolo devices,Material has been in unitypackage.


## NOLOVR SDK Version 0.1 beta
### The version number of Unity SDK is now changed from 1.1.7 to 0.1 beta. 

* 1.Fixed the abnormal issue of yaw correction.      
* 2.Fixed the software crash issue when completed editing in Unity.
* 3.Added choices of platforms (Cardboard, Daydream, GearVR); before Build, please make sure the selected platform and Unity VR Support platform are matched respectively.
* 4.Added directional buttons on the touchpad (i.e. up, down, left, right).
 
Documentation for the API is available on the [Wiki](https://github.com/NOLOVR/NOLO-Unity-SDK/wiki).


