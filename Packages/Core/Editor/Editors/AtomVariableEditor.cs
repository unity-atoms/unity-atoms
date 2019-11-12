using System;
using UnityEditor;
using UnityEngine;

namespace UnityAtoms.Editor{
    /// <summary>
    /// Custom editor for Variables. Provides a better user workflow and indicates when which variables can be edited
    /// </summary>
    public abstract class AtomVariableEditor : UnityEditor.Editor
    {
        private bool _lockedInitialValue = true;
        public override void OnInspectorGUI()
        {
            bool dontApply = false;
            EditorGUILayout.PropertyField(serializedObject.FindProperty("_developerDescription"));
            EditorGUILayout.Space();

            EditorGUILayout.BeginHorizontal();
            EditorGUI.BeginDisabledGroup(_lockedInitialValue && EditorApplication.isPlayingOrWillChangePlaymode);
            EditorGUILayout.PropertyField(serializedObject.FindProperty("_initialValue"));
            EditorGUI.EndDisabledGroup();
            if(EditorApplication.isPlaying)
            {
                _lockedInitialValue = GUILayout.Toggle(_lockedInitialValue, "", new GUIStyle("IN LockButton"){fixedHeight = 16, margin = new RectOffset(0, 2, 4, 0)});
            }
            EditorGUILayout.EndHorizontal();

            EditorGUI.BeginDisabledGroup(!EditorApplication.isPlaying);
            EditorGUI.BeginChangeCheck();
            EditorGUILayout.PropertyField(serializedObject.FindProperty("_value"), true);
            if (EditorGUI.EndChangeCheck() && target is AtomBaseVariable atomTarget)
            {
                var value = serializedObject.FindProperty("_value").GetPropertyValue();
                atomTarget.BaseValue = value;
                dontApply = true;
            }
            EditorGUI.EndDisabledGroup();


            EditorGUI.BeginDisabledGroup(true);
            EditorGUILayout.PropertyField(serializedObject.FindProperty("_oldValue"));
            EditorGUI.EndDisabledGroup();

            EditorGUILayout.PropertyField(serializedObject.FindProperty("Changed"));
            EditorGUILayout.PropertyField(serializedObject.FindProperty("ChangedWithHistory"));

            if(!dontApply) serializedObject.ApplyModifiedProperties();
        }
    }
}
