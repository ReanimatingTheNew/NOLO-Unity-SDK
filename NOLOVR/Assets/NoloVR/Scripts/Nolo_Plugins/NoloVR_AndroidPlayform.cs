/*************************************************************
 * 
 *  Copyright(c) 2017 Lyrobotix.Co.Ltd.All rights reserved.
 *  NoloVR_AndroidPlayform.cs
 *   
*************************************************************/
#if UNITY_ANDROID && !UNITY_EDITOR
#endif

using UnityEngine;
using System;

public class NoloVR_AndroidPlayform : NoloVR_Playform
{
    AndroidJavaClass unityPlayer;
    AndroidJavaObject currentActivity;
    AndroidJavaObject context;
    AndroidJavaObject jc, jo;
    public override bool InitDevice()
    {
        try
        {
            
            playformError = NoloError.NoConnect;
            //init serves
            unityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
            currentActivity = unityPlayer.GetStatic<AndroidJavaObject>("currentActivity");
            context = currentActivity.Call<AndroidJavaObject>("getApplicationContext");
            jc = new AndroidJavaClass("com.watchdata.usbhostconn.UsbCustomTransfer");
            jo = jc.CallStatic<AndroidJavaObject>("getInstance", context);
            jo.Call("usb_init");
          
        }
        catch (Exception e)
        {
            Debug.Log("NoloVR_AndroidPlayform InitDevice:error"+e.Message);
            playformError = NoloError.ConnectFail;
            return false;
        }
        return true;
    }
    //Connect Device Method
    public override bool ConnectDevice()
    {
        //try
        //{
        //    int result = jo.Call<int>("usb_conn");
        //    Debug.Log("NoloVR_AndroidPlayform ConnectDevice:"+result);
        //    if (result == 1)
        //    {
        //        playformError = NoloError.None;
        //    }
        //}
        //catch (Exception e)
        //{
        //    Debug.Log("NoloVR_AndroidPlayform ConnectDevice:error"+e.Message);
        //    playformError = NoloError.ConnectFail;
        //    return false;
        //}
        return true;
    }

    //Close connected
    public override void DisconnectDevice()
    {
        //jo.Call("usb_finish");
        unityPlayer = null;
        currentActivity = null;
        context = null;
        jo = null;
        jc = null;
        playformError = NoloError.DisConnect;
    }
     
    //Reconnect Device CallBack
    public override void ReconnectDeviceCallBack()
    {
        //do nothing
        Debug.Log("nolo_android_ReconnectDeviceCallBack");
        playformError = NoloError.None;
    }

    //Disconnect callback
    public override void DisConnectedCallBack()
    {
        playformError = NoloError.DisConnect;
        Debug.Log("nolo_android_DisConnectedCallBack");
    }

    // Pre HapticPulse message
    int preDeviceIndex = -1;
    byte preDeviceIndexIntensity;
    // HapticPulse
    // DeviceIndex: device leftcontroller or rightcontroller
    // Intensity: range 0~100 
    public override void TriggerHapticPulse(int deviceIndex, int intensity)
    {
        try
        {
            jo.Call("triggerHapticPulse", deviceIndex, intensity);
        }
        catch (System.Exception e)
        {
            Debug.LogError("Android playform sendData_usb error:" + e);
        }
    }

    public override void SetHmdTrackingCenter(NoloVR_Plugins.Nolo_Vector3 vec)
    {
        NoloVR_Plugins.API_2_0_0.SetHmdTrackingCenter(vec);
    }
}
