using System;
using System.Reflection;
using UnityEditor;
using UnityEngine;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Custom editor for Variables. Provides a better user workflow and indicates when which variables can be edited
    /// </summary>
    public abstract class AtomVariableEditor : UnityEditor.Editor
    {
        private bool _lockedInitialValue = true;
        public override void OnInspectorGUI()
        {
            serializedObject.Update();

            bool valueWasUpdated = false;
            EditorGUILayout.PropertyField(serializedObject.FindProperty("_developerDescription"));
            EditorGUILayout.Space();

            EditorGUILayout.BeginHorizontal();
            EditorGUI.BeginDisabledGroup(_lockedInitialValue && EditorApplication.isPlayingOrWillChangePlaymode);
            EditorGUILayout.PropertyField(serializedObject.FindProperty("_initialValue"), true);
            EditorGUI.EndDisabledGroup();
            if (EditorApplication.isPlaying)
            {
                _lockedInitialValue = GUILayout.Toggle(_lockedInitialValue, "", new GUIStyle("IN LockButton") { fixedHeight = 16, margin = new RectOffset(0, 2, 4, 0) });
            }
            EditorGUILayout.EndHorizontal();


            using (new EditorGUI.DisabledGroupScope(!EditorApplication.isPlaying))
            {
                EditorGUI.BeginChangeCheck();
                EditorGUILayout.PropertyField(serializedObject.FindProperty("_value"), true);
                if (EditorGUI.EndChangeCheck() && target is AtomBaseVariable atomTarget)
                {
                    try
                    {
                        var value = serializedObject.FindProperty("_value").GetPropertyValue();
                        atomTarget.BaseValue = value;
                    }
                    catch (InvalidOperationException)
                    {
                        var value = serializedObject.FindProperty("_value").GetGenericPropertyValue(atomTarget.BaseValue);
                        atomTarget.BaseValue = value;
                    }
                    valueWasUpdated = true;
                }
            }


            EditorGUI.BeginDisabledGroup(true);
            EditorGUILayout.PropertyField(serializedObject.FindProperty("_oldValue"), true);
            EditorGUI.EndDisabledGroup();

            const int raiseButtonWidth = 52;

            using (new EditorGUILayout.HorizontalScope())
            {
                EditorGUILayout.PropertyField(serializedObject.FindProperty("Changed"));
                var changed = serializedObject.FindProperty("Changed").objectReferenceValue;
                if (changed != null && changed is AtomEvent evt && target is AtomBaseVariable atomTarget)
                {
                    GUILayout.Space(2);
                    if (GUILayout.Button("Raise", GUILayout.Width(raiseButtonWidth), GUILayout.Height(EditorGUIUtility.singleLineHeight)))
                        evt.GetType().GetMethod("Raise", BindingFlags.Public | BindingFlags.Instance)?.Invoke(evt, new[] { atomTarget.BaseValue });
                }

            }

            using (new EditorGUILayout.HorizontalScope())
            {
                EditorGUILayout.PropertyField(serializedObject.FindProperty("ChangedWithHistory"));
                var changedWithHistory = serializedObject.FindProperty("ChangedWithHistory").objectReferenceValue;
                if (changedWithHistory != null && changedWithHistory is AtomEvent evt && target is AtomBaseVariable atomTarget)
                {
                    object oldValue = serializedObject.FindProperty("_oldValue").GetGenericPropertyValue(atomTarget.BaseValue);

                    GUILayout.Space(2);
                    if (GUILayout.Button("Raise", GUILayout.Width(raiseButtonWidth), GUILayout.Height(EditorGUIUtility.singleLineHeight)))
                    {
                        if (GUILayout.Button("Raise", GUILayout.Width(raiseButtonWidth), GUILayout.Height(EditorGUIUtility.singleLineHeight)))
                            evt.GetType().GetMethod("Raise", BindingFlags.Public | BindingFlags.Instance)
                                ?.Invoke(evt, new[] { atomTarget.BaseValue, oldValue });

                    }
                }

            }


            if (!valueWasUpdated)
            {
                serializedObject.ApplyModifiedProperties();
            }
        }
    }
}
