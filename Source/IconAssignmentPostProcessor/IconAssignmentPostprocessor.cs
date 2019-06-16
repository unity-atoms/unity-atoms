using System;
using System.IO;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.Reflection;
using UnityAtoms;

namespace UnityAtoms
{
    public class IconAssignmentPostprocessor : AssetPostprocessor
    {
        static AtomsIconAssignmentProcessor _iconAssignment = new AtomsIconAssignmentProcessor();

        static IconAssignmentPostprocessor()
        {
            _iconAssignment.ReloadIconsFromSettings();
        }

        static void OnPostprocessAllAssets(string[] importedAssets, string[] deletedAssets, string[] movedAssets, string[] movedFromAssetPaths)
        {
            _iconAssignment.Process(importedAssets);
        }
    }
}
