﻿using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

namespace FMODUnity
{
    public class PlatformDefault : Platform
    {
        public PlatformDefault()
        {
            Identifier = ConstIdentifier;
        }

        public const string ConstIdentifier = "default";

        public override string DisplayName { get { return "Default Settings"; } }
        public override void DeclareUnityMappings(Settings settings) { }
#if UNITY_EDITOR
        public override Legacy.Platform LegacyIdentifier { get { return Legacy.Platform.Default; } }

        protected override IEnumerable<string> GetRelativeBinaryPaths(BuildTarget buildTarget, string suffix)
        {
            yield break;
        }
#endif

        public override bool IsIntrinsic { get { return true; } }

        public override void InitializeProperties()
        {
            base.InitializeProperties();

            PropertyAccessors.Plugins.Set(this, new List<string>());
        }
    }
}
