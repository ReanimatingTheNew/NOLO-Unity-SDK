/*************************************************************
 * 
 *  Copyright(c) 2017 Lyrobotix.Co.Ltd.All rights reserved.
 *  NoloVR_Utils.cs
 *   
*************************************************************/
using UnityEngine;
using System.Collections;

public struct Nolo_Transform
{
    public Vector3 pos;
    public Quaternion rot;
    public Vector3 vecVelocity;
    public Vector3 vecAngularVelocity;

    public Nolo_Transform(NoloVR_Plugins.Nolo_Pose pose)
    {
        this.pos.x = pose.pos.x;
        this.pos.y = pose.pos.y;
        this.pos.z = pose.pos.z;

        this.rot.w = pose.rot.w;
        this.rot.x = pose.rot.x;
        this.rot.y = pose.rot.y;
        this.rot.z = pose.rot.z;

        this.vecVelocity.x = pose.vecVelocity.x;
        this.vecVelocity.y = pose.vecVelocity.y;
        this.vecVelocity.z = -pose.vecVelocity.z;

        this.vecAngularVelocity.x = pose.vecAngularVelocity.x;
        this.vecAngularVelocity.y = pose.vecAngularVelocity.y;
        this.vecAngularVelocity.z = pose.vecAngularVelocity.z;

    }
    public Nolo_Transform(Vector3 pos,Quaternion rot,Vector3 vecVelocity,Vector3 vecAngularVelocity)
    {
        this.pos = pos;
        this.rot = rot;
        this.vecVelocity = vecVelocity;
        this.vecAngularVelocity = vecAngularVelocity;
    }
    public static Nolo_Transform identity
    {
       get { return new Nolo_Transform(Vector3.zero, Quaternion.identity,Vector3.zero,Vector3.zero); }
    }
}

public class NOLO_Events
{
    public enum EventsType
    {
        TrackingOutofRange,
        TrackingInRange,
        TurnAround
    }
    public delegate void Handler(params object[] args);

    public static void Listen(EventsType eventMessage, Handler action)
    {
        var actions = listeners[eventMessage] as Handler;
        if (actions != null)
        {
            listeners[eventMessage] = actions + action;
        }
        else
        {
            listeners[eventMessage] = action;
        }
    }

    public static void Remove(EventsType eventMessage, Handler action)
    {
        var actions = listeners[eventMessage] as Handler;
        if (actions != null)
        {
            listeners[eventMessage] = actions - action;
        }
    }

    public static void Send(EventsType eventMessage, params object[] args)
    {
        var actions = listeners[eventMessage] as Handler;
        if (actions != null)
        {
            actions(args);
        }
    }

    private static Hashtable listeners = new Hashtable();

}


public class NoloVR_Utils
{
    //Correction of yaw speed unit: degree / sec
    static float angleAdjustmentRate = 0.008f;

    public static NoloVR_Plugins.Nolo_Vector3 GetHmdTrackingCenter(NoloVR_Manager.NoloAndroidVRPlayform vrPlayform)
    {
        NoloVR_Plugins.Nolo_Vector3 vec = new NoloVR_Plugins.Nolo_Vector3();
        switch (vrPlayform)
        {
            case NoloVR_Manager.NoloAndroidVRPlayform.GearVR:
                vec.x = 0f;
                vec.y = 0.065f;
                vec.z = 0.060f;
                break;
            case NoloVR_Manager.NoloAndroidVRPlayform.DayDream:
                vec.x = 0f;
                vec.y = 0.08f;
                vec.z = 0.062f;
                break;
            case NoloVR_Manager.NoloAndroidVRPlayform.CardBoard:
                vec.x = 0f;
                vec.y = 0.094f;
                vec.z = 0.048f;
                break;
            case NoloVR_Manager.NoloAndroidVRPlayform.Other:
                vec.x = 0f;
                vec.y = 0f;
                vec.z = 0f;
                break;
            default:
                break;
        }
        return vec;
    }

    public static Quaternion GetRecenterRot(Quaternion rot,float presetyaw,float setyaw)
    {
        if (rot.x > -0.4f && rot.x < 0.4f)
        {
            if (setyaw > -360 && setyaw < -340)
            {
                return Quaternion.Euler(0, presetyaw + angleAdjustmentRate, 0);
            }
            else if (setyaw > 0 && setyaw < 20)
            {
                return Quaternion.Euler(0, presetyaw + angleAdjustmentRate, 0);
            }
            else if (setyaw > -20 && setyaw < 0)
            {
                return Quaternion.Euler(0, presetyaw - angleAdjustmentRate, 0);
            }
            else
            {
                return Quaternion.Euler(0, presetyaw+ setyaw, 0);
            }
        }
        return Quaternion.Euler(0, presetyaw, 0);
    }

}



