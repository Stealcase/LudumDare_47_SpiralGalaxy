﻿using System.Collections.Generic;
using System;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

#if UNITY_ANDROID && !UNITY_EDITOR
namespace FMOD
{
    public partial class VERSION
    {
        public const string dll = "fmod" + dllSuffix;
    }
}

namespace FMOD.Studio
{
    public partial class STUDIO_VERSION
    {
        public const string dll = "fmodstudio" + dllSuffix;
    }
}
#endif

namespace FMODUnity
{
#if UNITY_EDITOR
    [InitializeOnLoad]
#endif
    public class PlatformAndroid : Platform
    {
        static PlatformAndroid()
        {
            Settings.AddPlatformTemplate<PlatformAndroid>("2fea114e74ecf3c4f920e1d5cc1c4c40");
        }

        public override string DisplayName { get { return "Android"; } }
        public override void DeclareUnityMappings(Settings settings)
        {
            settings.DeclareRuntimePlatform(RuntimePlatform.Android, this);

#if UNITY_EDITOR
            settings.DeclareBuildTarget(BuildTarget.Android, this);
#endif
        }

#if UNITY_EDITOR
        public override Legacy.Platform LegacyIdentifier { get { return Legacy.Platform.Android; } }

        protected override IEnumerable<string> GetRelativeBinaryPaths(BuildTarget buildTarget, string suffix)
        {
            yield return "android/fmod.jar";

            foreach (string architecture in new[] { "arm64-v8a", "armeabi-v7a", "x86" })
            {
                yield return string.Format("android/{0}/libfmod{1}.so", architecture, suffix);
                yield return string.Format("android/{0}/libfmodstudio{1}.so", architecture, suffix);
            }
        }
#endif

        public override string GetBankFolder()
        {
            return Settings.Instance.AndroidUseOBB ? Application.streamingAssetsPath : "file:///android_asset";
        }

        public override string GetPluginPath(string pluginName)
        {
            return StaticGetPluginPath(pluginName);
        }

        public static string StaticGetPluginPath(string pluginName)
        {
            return string.Format("lib{0}.so", pluginName);
        }
    }
}
