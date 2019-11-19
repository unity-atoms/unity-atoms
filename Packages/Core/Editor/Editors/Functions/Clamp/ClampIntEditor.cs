using System;
using System.Reflection;
using UnityEditor;
using UnityEngine;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Custom editor for Variables. Provides a better user workflow and indicates when which variables can be edited
    /// </summary>
    [CustomEditor(typeof(ClampInt))]
    public class ClampIntEditor : UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            ClampInt clamp = (ClampInt)target;
            if (clamp != null && !clamp.IsValid())
            {
                EditorGUILayout.HelpBox("Min value must be less than or equal to Max value.", MessageType.Warning);
            }
        }
    }
}
