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
        
        private static SteamVR_Input_ActionSet_VRThrow p_VRThrow;
        
        public static SteamVR_Input_ActionSet_VRThrow VRThrow
        {
            get
            {
                return SteamVR_Actions.p_VRThrow.GetCopy<SteamVR_Input_ActionSet_VRThrow>();
            }
        }
        
        private static void StartPreInitActionSets()
        {
            SteamVR_Actions.p_VRThrow = ((SteamVR_Input_ActionSet_VRThrow)(SteamVR_ActionSet.Create<SteamVR_Input_ActionSet_VRThrow>("/actions/VRThrow")));
            Valve.VR.SteamVR_Input.actionSets = new Valve.VR.SteamVR_ActionSet[] {
                    SteamVR_Actions.VRThrow};
        }
    }
}