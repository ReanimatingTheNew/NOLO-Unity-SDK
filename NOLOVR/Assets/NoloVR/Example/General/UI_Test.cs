using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class UI_Test : MonoBehaviour {
    private Text UIText;
	void Start () {
        UIText = GetComponent<Text>();
    }

    void Update()
    {
        try
        {
            UIText.text =
              "HMD POS       :" + NoloVR_Controller.GetDevice(NoloDeviceType.Hmd).GetPose().pos + "\n"
             + "HMD ROT       :" + NoloVR_Controller.GetDevice(NoloDeviceType.Hmd).GetPose().rot + "\n"
            + "HMD VER       :" + NoloVR_Plugins.API_1_0_0.GetVersionByDeviceType(0) + "\n"
            + "HMD TRACK     :" + NoloVR_Plugins.GetTrackingStatus(0) + "\n"
            + "HMD VEC     :" + NoloVR_Controller.GetDevice(NoloDeviceType.Hmd).GetPose().vecVelocity + "\n"
            + "HMD ANGULAR     :" + NoloVR_Controller.GetDevice(NoloDeviceType.Hmd).GetPose().vecAngularVelocity + "\n"

            + "LEFT POS      :" + NoloVR_Controller.GetDevice(NoloDeviceType.LeftController).GetPose().pos + "RIGHT POS     :" + NoloVR_Controller.GetDevice(NoloDeviceType.RightController).GetPose().pos + "\n"
            + "LEFT ROT      :" + NoloVR_Controller.GetDevice(NoloDeviceType.LeftController).GetPose().rot+ "RIGHT ROT     :" + NoloVR_Controller.GetDevice(NoloDeviceType.RightController).GetPose().rot + "\n"
            + "LEFT VEC      :" + NoloVR_Controller.GetDevice(NoloDeviceType.LeftController).GetPose().vecVelocity + "RIGHT VEC      :" + NoloVR_Controller.GetDevice(NoloDeviceType.RightController).GetPose().vecVelocity + "\n"
             + "LEFT ANGULAR      :" + NoloVR_Controller.GetDevice(NoloDeviceType.LeftController).GetPose().vecAngularVelocity + "RIGHT ANGULAR      :" + NoloVR_Controller.GetDevice(NoloDeviceType.RightController).GetPose().vecAngularVelocity + "\n"

            + "LEFT TRIGGER  :" + NoloVR_Controller.GetDevice(NoloDeviceType.LeftController).GetNoloButtonPressed(NoloButtonID.Trigger) + "RIGHT TRIGGER :" + NoloVR_Controller.GetDevice(NoloDeviceType.RightController).GetNoloButtonPressed(NoloButtonID.Trigger) + "\n"
            + "LEFT MENU     :" + NoloVR_Controller.GetDevice(NoloDeviceType.LeftController).GetNoloButtonPressed(NoloButtonID.Menu) + "RIGHT MENU    :" + NoloVR_Controller.GetDevice(NoloDeviceType.RightController).GetNoloButtonPressed(NoloButtonID.Menu) + "\n"
            + "LEFT TOUCHPAD :" + NoloVR_Controller.GetDevice(NoloDeviceType.LeftController).GetNoloButtonPressed(NoloButtonID.TouchPad) + "RIGHT TOUCHPAD:" + NoloVR_Controller.GetDevice(NoloDeviceType.RightController).GetNoloButtonPressed(NoloButtonID.TouchPad) + "\n"
            + "LEFT SYSTEM   :" + NoloVR_Controller.GetDevice(NoloDeviceType.LeftController).GetNoloButtonPressed(NoloButtonID.System) + "RIGHT SYSTEM  :" + NoloVR_Controller.GetDevice(NoloDeviceType.RightController).GetNoloButtonPressed(NoloButtonID.System) + "\n"
            + "LEFT GRIP     :" + NoloVR_Controller.GetDevice(NoloDeviceType.LeftController).GetNoloButtonPressed(NoloButtonID.Grip) + "RIGHT GRIP    :" + NoloVR_Controller.GetDevice(NoloDeviceType.RightController).GetNoloButtonPressed(NoloButtonID.Grip) + "\n"
            + "LEFT up     :" + NoloVR_Controller.GetDevice(NoloDeviceType.LeftController).GetNoloButtonPressed(NoloButtonID.TouchPadUp) + "RIGHT up     :" + NoloVR_Controller.GetDevice(NoloDeviceType.RightController).GetNoloButtonPressed(NoloButtonID.TouchPadUp) + "\n"
            + "LEFT down     :" + NoloVR_Controller.GetDevice(NoloDeviceType.LeftController).GetNoloButtonPressed(NoloButtonID.TouchPadDown) + "RIGHT down     :" + NoloVR_Controller.GetDevice(NoloDeviceType.RightController).GetNoloButtonPressed(NoloButtonID.TouchPadDown) + "\n"
            + "LEFT left     :" + NoloVR_Controller.GetDevice(NoloDeviceType.LeftController).GetNoloButtonPressed(NoloButtonID.TouchPadLeft) + "RIGHT left     :" + NoloVR_Controller.GetDevice(NoloDeviceType.RightController).GetNoloButtonPressed(NoloButtonID.TouchPadLeft) + "\n"
            + "LEFT right     :" + NoloVR_Controller.GetDevice(NoloDeviceType.LeftController).GetNoloButtonPressed(NoloButtonID.TouchPadRight) + "RIGHT right     :" + NoloVR_Controller.GetDevice(NoloDeviceType.RightController).GetNoloButtonPressed(NoloButtonID.TouchPadRight) + "\n"
            + "LEFT AXIS     :" + NoloVR_Controller.GetDevice(NoloDeviceType.LeftController).GetAxis() + "RIGHT AXIS    :" + NoloVR_Controller.GetDevice(NoloDeviceType.RightController).GetAxis() + "\n"
            + "LEFT ELE      :" + NoloVR_Plugins.GetElectricity(1) + "RIGHT ELE     :" + NoloVR_Plugins.GetElectricity(2) + "\n"
            + "LEFT TRACK    :" + NoloVR_Plugins.GetTrackingStatus(1) + "RIGHT TRACK   :" + NoloVR_Plugins.GetTrackingStatus(2) + "\n";

        }
        catch (System.Exception e)
        {
            Debug.Log("Catch"+e.Message);
            throw;
        }
        

    }
}
