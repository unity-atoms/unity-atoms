using System;
using System.Reflection;
using UnityEditor;
using UnityEngine;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Base class for a custom editor for Clamp Functions.
    /// </summary>
    public abstract class ClampBaseEditor : UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            IIsValid iIsValid = (IIsValid)target;
            if (iIsValid != null && !iIsValid.IsValid())
            {
                EditorGUILayout.HelpBox("Min value must be less than or equal to Max value.", MessageType.Warning);
            }
        }
    }
}
