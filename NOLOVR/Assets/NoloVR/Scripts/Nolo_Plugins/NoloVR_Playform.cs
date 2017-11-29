/*************************************************************
 * 
 *  Copyright(c) 2017 Lyrobotix.Co.Ltd.All rights reserved.
 *  NoloVR_Playform.cs
 *   
*************************************************************/

public abstract class NoloVR_Playform
{


    public abstract bool InitDevice();
   
    public abstract bool ConnectDevice(); 
   
    public abstract void DisconnectDevice();
   
    public abstract void ReconnectDeviceCallBack(); 
    
    public abstract void DisConnectedCallBack();
  
    public abstract void TriggerHapticPulse(int deviceIndex,int intensity);

    public abstract void SetHmdTrackingCenter(NoloVR_Plugins.Nolo_Vector3 vec);

    protected static NoloError playformError = NoloError.UnKnow;

    public NoloError GetPlayformError()
    {
        return playformError;
    }

    protected NoloVR_Playform()
    {
        if (playformError == NoloError.UnKnow)
        {
            InitDevice();
        }
    }

    private static NoloVR_Playform instance;

    public static NoloVR_Playform InitPlayform()
    {
        if (instance == null)
        {
#if UNITY_STANDALONE_WIN || UNITY_EDITOR
            instance = new NoloVR_WinPlayform();
#elif UNITY_ANDROID
            instance = new NoloVR_AndroidPlayform();
#else
           instance = new NoloVR_OtherPlayform();
#endif
        }
        return instance;
    }

    ~NoloVR_Playform()
    {
        if (instance != null)
        {
            DisconnectDevice();
            instance = null;
        }
    }

}