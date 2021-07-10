using System;
using System.Reflection;
using UnityEditor;
using UnityEngine;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Custom editor for Variables. Provides a better user workflow and indicates when which variables can be edited
    /// </summary>
    [CustomEditor(typeof(AtomVariable<>), true)]
    public class AtomVariableEditor : UnityEditor.Editor
    {
        private bool _lockedInitialValue = true;
        private bool _onEnableTriggerSectionVisible = true;

        protected Type _variableType;

        protected virtual void OnEnable()
        {
            var val = target.GetType().GetField("_value", BindingFlags.Instance | BindingFlags.NonPublic);
            _variableType = val.FieldType;
        }

        public override void OnInspectorGUI()
        {
            serializedObject.Update();

            DisplayScopeDropdown();

            GUI.enabled = true;

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
                        if (_variableType == typeof(double))
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
                        var value = serializedObject.FindProperty("_value").GetGenericPropertyValue(JsonUtility.FromJson(JsonUtility.ToJson(atomTarget.BaseValue), _variableType));
                        atomTarget.BaseValue = value;
                    }
                    serializedObject.Update();
                }
            }


            EditorGUI.BeginDisabledGroup(true);
            EditorGUILayout.PropertyField(serializedObject.FindProperty("_oldValue"), true);
            EditorGUI.EndDisabledGroup();

            const int raiseButtonWidth = 52;

            using (new EditorGUILayout.HorizontalScope())
            {
                EditorGUILayout.PropertyField(serializedObject.FindProperty("_changed"));
                var changed = serializedObject.FindProperty("_changed").objectReferenceValue;
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
                EditorGUILayout.PropertyField(serializedObject.FindProperty("_changedWithHistory"));
                var changedWithHistory = serializedObject.FindProperty("_changedWithHistory").objectReferenceValue;
                if (changedWithHistory != null && changedWithHistory is AtomEventBase evt && target is AtomBaseVariable atomTarget)
                {
                    GUILayout.Space(2);
                    if (GUILayout.Button("Raise", GUILayout.Width(raiseButtonWidth), GUILayout.Height(EditorGUIUtility.singleLineHeight)))
                    {
                        var oldValueProp = serializedObject.FindProperty("_oldValue");
                        object oldValue = oldValueProp.GetPropertyValue();

                        var genericPair = typeof(Pair<>);
                        var constructedPair = genericPair.MakeGenericType(new[] { _variableType });
                        var pair = Activator.CreateInstance(constructedPair);

                        constructedPair.GetProperty(nameof(Pair<object>.Item1)).SetValue(pair, atomTarget.BaseValue);
                        constructedPair.GetProperty(nameof(Pair<object>.Item2), _variableType).SetValue(pair, oldValue);

                        evt.GetType().GetMethod("RaiseEditor", BindingFlags.Public | BindingFlags.Instance)?.Invoke(evt, new[] { pair });
                    }
                }
            }

            EditorGUILayout.PropertyField(serializedObject.FindProperty("_preChangeTransformers"), true);

            _onEnableTriggerSectionVisible = EditorGUILayout.Foldout(_onEnableTriggerSectionVisible, "Trigger Event on OnEnable");
            if (_onEnableTriggerSectionVisible)
            {
                EditorGUILayout.PropertyField(serializedObject.FindProperty("_triggerChangedOnOnEnable"), new GUIContent("Changed"));
                EditorGUILayout.PropertyField(serializedObject.FindProperty("_triggerChangedWithHistoryOnOnEnable"), new GUIContent("ChangedWithHistory"));
            }

            serializedObject.ApplyModifiedProperties();
        }

        /// <summary>
        /// Display scope dropdown and warning if the addressable package is in use
        /// </summary>
        private void DisplayScopeDropdown()
        {
            if (Application.isPlaying) GUI.enabled = false;
            #if USE_ADDRESSABLES
            AddressableAssetSettings settings = AddressableAssetSettingsDefaultObject.Settings;
            string assetPath = AssetDatabase.GetAssetPath(serializedObject.targetObject);
            string guid = AssetDatabase.AssetPathToGUID(assetPath);
            AddressableAssetEntry entry = settings.FindAssetEntry(guid);
            #endif

            SerializedProperty scope = serializedObject.FindProperty("_scope");
            #if USE_ADDRESSABLES
            if (entry != null)
            {
                GUI.enabled = false;
                scope.enumValueIndex = 2;
            }
            #endif
            EditorGUILayout.PropertyField(scope);
            #if USE_ADDRESSABLES
            if (entry != null)
            {
                EditorGUILayout.HelpBox("This asset is marked as addressable, his lifetime will not be managed by Unity Atoms.\nSee more in documentation", MessageType.Warning);
            }
            else
            {
                EditorGUILayout.HelpBox("Addressables is installed, careful, Unity Atoms might be unable to manage the asset.\nSee more in documentation", MessageType.Info);
            }
            #endif

            EditorGUILayout.Space();
        }
    }
}
