using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using BoplFixedMath;
using HarmonyLib;
using System.Reflection;
using System;
using System.Runtime.CompilerServices;
using UnityEngine.InputSystem;
using UnityEngine.Networking;
namespace Microsoft.CodeAnalysis
{
    [CompilerGenerated]
    [Microsoft.CodeAnalysis.Embedded]
    internal sealed class EmbeddedAttribute : Attribute
    {
    }
}
namespace System.Runtime.CompilerServices
{
    [CompilerGenerated]
    [Microsoft.CodeAnalysis.Embedded]
    [AttributeUsage(AttributeTargets.Module, AllowMultiple = false, Inherited = false)]
    internal sealed class RefSafetyRulesAttribute : Attribute
    {
        public readonly int Version;

        public RefSafetyRulesAttribute(int P_0)
        {
            Version = P_0;
        }
    }
}
namespace CantMove
{
    [BepInPlugin("com.SashaAnt.CantMove", "CantMove", "1.0.0")]
    public class Plugin : BaseUnityPlugin
    {

        private void Awake()
        {
            //IL_004f: Unknown result type (might be due to invalid IL or missing references)
            //IL_0059: Expected O, but got Unknown
            Harmony val = new Harmony("com.SashaAnt.CantMove");
            MethodInfo methodInfo = AccessTools.Method(typeof(PlayerPhysics), "Move", (Type[])null, (Type[])null);
            MethodInfo methodInfo2 = AccessTools.Method(typeof(Patches), "Patch", (Type[])null, (Type[])null);
            val.Patch((MethodBase)methodInfo, new HarmonyMethod(methodInfo2), (HarmonyMethod)null, (HarmonyMethod)null, (HarmonyMethod)null, (HarmonyMethod)null);
        }
    }
    [HarmonyPatch(typeof(PlayerPhysics))]
    public class Patches
    {
        [HarmonyPatch("Awake")]
        [HarmonyPrefix]
        public static void Patch(PlayerPhysics __instance)
        {
            __instance.maxSpeed = (Fix)(0L);
            
        }

    }

    public static class PluginInfo
    {
        public const string PLUGIN_GUID = "CantMove";

        public const string PLUGIN_NAME = "CantMove";

        public const string PLUGIN_VERSION = "1.0.0";
    }
}
