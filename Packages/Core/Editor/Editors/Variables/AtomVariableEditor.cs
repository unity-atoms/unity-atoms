using System;
using System.Reflection;
using UnityEditor;
using UnityEngine;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Custom editor for Variables. Provides a better user workflow and indicates when which variables can be edited
    /// </summary>
    public abstract class AtomVariableEditor<T, P> : UnityEditor.Editor
        where P : IPair<T>, new()
    {
        private bool _lockedInitialValue = true;
        public override void OnInspectorGUI()
        {
            serializedObject.Update();

            bool valueWasUpdated = false;
            EditorGUILayout.PropertyField(serializedObject.FindProperty("_developerDescription"));
            EditorGUILayout.Space();

            EditorGUILayout.PropertyField(serializedObject.FindProperty("_id"));

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

                        // Doubles are for some reason deserialized to floats. The BaseValue assignment below will fail if we don't cast it to float and then to double before assignment (since the assigment itself will otherwise do a cast from object to double which will crash).
                        if (typeof(T) == typeof(double))
                        {
                            atomTarget.BaseValue = (double)(float)value;
                        }
                        else
                        {
                            atomTarget.BaseValue = value;
                        }

                    }
                    catch (InvalidOperationException)
                    {
                        // Deep clone the base value using JsonUtility. Otherwise oldValue and initialValue will all change when changing value.
                        var value = serializedObject.FindProperty("_value").GetGenericPropertyValue(JsonUtility.FromJson<T>(JsonUtility.ToJson(atomTarget.BaseValue)));
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
                if (changed != null && changed is AtomEventBase evt && target is AtomBaseVariable atomTarget)
                {
                    GUILayout.Space(2);
                    if (GUILayout.Button("Raise", GUILayout.Width(raiseButtonWidth), GUILayout.Height(EditorGUIUtility.singleLineHeight)))
                    {
                        evt.GetType().GetMethod("RaiseEditor", BindingFlags.Public | BindingFlags.Instance)?.Invoke(evt, new[] { atomTarget.BaseValue });
                    }
                }

            }

            using (new EditorGUILayout.HorizontalScope())
            {
                EditorGUILayout.PropertyField(serializedObject.FindProperty("ChangedWithHistory"));
                var changedWithHistory = serializedObject.FindProperty("ChangedWithHistory").objectReferenceValue;
                if (changedWithHistory != null && changedWithHistory is AtomEventBase evt && target is AtomBaseVariable atomTarget)
                {

                    GUILayout.Space(2);
                    if (GUILayout.Button("Raise", GUILayout.Width(raiseButtonWidth), GUILayout.Height(EditorGUIUtility.singleLineHeight)))
                    {
                        var oldValueProp = serializedObject.FindProperty("_oldValue");
                        object oldValue = oldValueProp.GetPropertyValue();
                        evt.GetType().GetMethod("RaiseEditor", BindingFlags.Public | BindingFlags.Instance)?.Invoke(evt, new[] { (object)(new P() { Item1 = (T)atomTarget.BaseValue, Item2 = (T)oldValue }) });
                    }
                }

            }

            EditorGUILayout.PropertyField(serializedObject.FindProperty("_preChangeTransformers"), true);

            if (!valueWasUpdated)
            {
                serializedObject.ApplyModifiedProperties();
            }
        }
    }
}
