//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Valve.VR
{
    using System;
    using UnityEngine;
    
    
    public partial class SteamVR_Actions
    {
        
        private static SteamVR_Action_Boolean p_vRThrow_grab;
        
        private static SteamVR_Action_Boolean p_vRThrow_reset;
        
        private static SteamVR_Action_Pose p_vRThrow_pose;
        
        public static SteamVR_Action_Boolean vRThrow_grab
        {
            get
            {
                return SteamVR_Actions.p_vRThrow_grab.GetCopy<SteamVR_Action_Boolean>();
            }
        }
        
        public static SteamVR_Action_Boolean vRThrow_reset
        {
            get
            {
                return SteamVR_Actions.p_vRThrow_reset.GetCopy<SteamVR_Action_Boolean>();
            }
        }
        
        public static SteamVR_Action_Pose vRThrow_pose
        {
            get
            {
                return SteamVR_Actions.p_vRThrow_pose.GetCopy<SteamVR_Action_Pose>();
            }
        }
        
        private static void InitializeActionArrays()
        {
            Valve.VR.SteamVR_Input.actions = new Valve.VR.SteamVR_Action[] {
                    SteamVR_Actions.vRThrow_grab,
                    SteamVR_Actions.vRThrow_reset,
                    SteamVR_Actions.vRThrow_pose};
            Valve.VR.SteamVR_Input.actionsIn = new Valve.VR.ISteamVR_Action_In[] {
                    SteamVR_Actions.vRThrow_grab,
                    SteamVR_Actions.vRThrow_reset,
                    SteamVR_Actions.vRThrow_pose};
            Valve.VR.SteamVR_Input.actionsOut = new Valve.VR.ISteamVR_Action_Out[0];
            Valve.VR.SteamVR_Input.actionsVibration = new Valve.VR.SteamVR_Action_Vibration[0];
            Valve.VR.SteamVR_Input.actionsPose = new Valve.VR.SteamVR_Action_Pose[] {
                    SteamVR_Actions.vRThrow_pose};
            Valve.VR.SteamVR_Input.actionsBoolean = new Valve.VR.SteamVR_Action_Boolean[] {
                    SteamVR_Actions.vRThrow_grab,
                    SteamVR_Actions.vRThrow_reset};
            Valve.VR.SteamVR_Input.actionsSingle = new Valve.VR.SteamVR_Action_Single[0];
            Valve.VR.SteamVR_Input.actionsVector2 = new Valve.VR.SteamVR_Action_Vector2[0];
            Valve.VR.SteamVR_Input.actionsVector3 = new Valve.VR.SteamVR_Action_Vector3[0];
            Valve.VR.SteamVR_Input.actionsSkeleton = new Valve.VR.SteamVR_Action_Skeleton[0];
            Valve.VR.SteamVR_Input.actionsNonPoseNonSkeletonIn = new Valve.VR.ISteamVR_Action_In[] {
                    SteamVR_Actions.vRThrow_grab,
                    SteamVR_Actions.vRThrow_reset};
        }
        
        private static void PreInitActions()
        {
            SteamVR_Actions.p_vRThrow_grab = ((SteamVR_Action_Boolean)(SteamVR_Action.Create<SteamVR_Action_Boolean>("/actions/VRThrow/in/grab")));
            SteamVR_Actions.p_vRThrow_reset = ((SteamVR_Action_Boolean)(SteamVR_Action.Create<SteamVR_Action_Boolean>("/actions/VRThrow/in/reset")));
            SteamVR_Actions.p_vRThrow_pose = ((SteamVR_Action_Pose)(SteamVR_Action.Create<SteamVR_Action_Pose>("/actions/VRThrow/in/pose")));
        }
    }
}