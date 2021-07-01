using System;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEditor.Compilation;
using UnityEngine;
using Assembly = System.Reflection.Assembly;

namespace UnityAtoms.Editor
{
    [CustomEditor(typeof(Generator), true)]
    public class GeneratorEditor : UnityEditor.Editor
    {
        private static TypeSelectorDropdown typeSelectorDropdown;
        private static bool lastSafeSearch;

        private SerializedProperty safeSearch;
        private SerializedProperty _assemblyQualifiedName;
        private SerializedProperty @namespace;
        private SerializedProperty _keys;
        private SerializedProperty _options;
        private SerializedProperty _scripts;

        private void OnEnable()
        {
            // Find Properties.
            safeSearch = serializedObject.FindProperty(nameof(safeSearch));
            _assemblyQualifiedName = serializedObject.FindProperty(nameof(_assemblyQualifiedName));
            @namespace = serializedObject.FindProperty(nameof(Generator.@namespace));
            _keys = serializedObject.FindProperty(nameof(_keys));
            _options = serializedObject.FindProperty(nameof(_options));
            _scripts = serializedObject.FindProperty(nameof(_scripts));
        }

        public void RefreshDropdown()
        {
            if (typeSelectorDropdown == null
                || lastSafeSearch != safeSearch.boolValue)
            {
                // Search Player assemblies only if safe searching, else search all assemblies.
                IEnumerable<Assembly> assemblies;
                if (safeSearch.boolValue)
                {
                    assemblies = from assemblyDefinition in CompilationPipeline.GetAssemblies(AssembliesType.Player)
                                 let assembly = Assembly.Load(assemblyDefinition.name)
                                 select assembly;
                }
                else
                {
                    assemblies = from assembly in AppDomain.CurrentDomain.GetAssemblies()
                                 select assembly;
                }

                // Find all types in unity that are not generic or abstract.
                var types = from assembly in assemblies
                            where !assembly.IsDynamic
                            from type in assembly.GetExportedTypes()
                            where !type.IsGenericType
                            where !type.IsAbstract
                            select type;

                // Disregard non serializable types if safe searching.
                if (safeSearch.boolValue)
                {
                    types = from type in types
                            where type.IsUnitySerializable()
                            select type;

                    types = types.Concat(from type in Assembly.GetAssembly(typeof(string)).GetExportedTypes()
                                         where type.IsPrimitive || type == typeof(string)
                                         where type != typeof(IntPtr)
                                         where type != typeof(UIntPtr)
                                         select type);

                    types = types.Concat(TypeExtensions.serializedBuiltInTypes);
                }

                // Create a type selector dropdown that sets properties when something is selected.
                typeSelectorDropdown = new TypeSelectorDropdown(types, selectedType =>
                {
                    serializedObject.Update();

                    _assemblyQualifiedName.stringValue = selectedType.AssemblyQualifiedName;

                    serializedObject.ApplyModifiedProperties();
                });
            }

            lastSafeSearch = safeSearch.boolValue;
        }

        public override void OnInspectorGUI()
        {
            var generator = target as Generator;

            serializedObject.Update();

            // Draw our type dropdown and result.
            const float rectMargin = 4f;

            var buttonContent = safeSearch.boolValue
                ? new GUIContent($"Select Unity Type", $"Select from all Unity compatible types.")
                : new GUIContent($"Select Unsafe Type", $"Select from all types, serializable or not. Be aware that some types may not be compatible with all platforms!");
            var buttonStyle = GUI.skin.button;
            var dropdownRect = EditorGUILayout.GetControlRect(false, buttonStyle.CalcHeight(buttonContent, 0f), buttonStyle);
            var toggleLabelRect = new Rect(dropdownRect);
            toggleLabelRect.width = 32f;
            var toggleRect = new Rect(dropdownRect);
            toggleRect.width = 16f;
            toggleRect.x += (toggleLabelRect.width + rectMargin);
            var buttonRect = new Rect(dropdownRect);
            buttonRect.width -= (toggleRect.width + toggleRect.x - toggleLabelRect.x + rectMargin);
            buttonRect.x += (toggleRect.width + toggleRect.x - toggleLabelRect.x + rectMargin);

            EditorGUILayout.BeginHorizontal();
            {
                EditorGUI.LabelField(toggleLabelRect, "Safe");

                EditorGUI.PropertyField(toggleRect, safeSearch, GUIContent.none);

                if (GUI.Button(buttonRect, buttonContent))
                {
                    RefreshDropdown();
                    typeSelectorDropdown.Show(dropdownRect);
                }
            }
            EditorGUILayout.EndHorizontal();

            // Draw the selected type name.
            var typeLabelRect = new Rect(toggleLabelRect);
            typeLabelRect.width = toggleRect.x + toggleRect.width;
            typeLabelRect.y += (EditorGUIUtility.singleLineHeight + rectMargin);
            var typeRect = new Rect(buttonRect);
            typeRect.y += (EditorGUIUtility.singleLineHeight + rectMargin);

            EditorGUI.BeginDisabledGroup(true);
            EditorGUI.LabelField(typeLabelRect, "Type");
            EditorGUI.TextField(typeRect, Type.GetType(_assemblyQualifiedName.stringValue)?.FullName);
            EditorGUILayout.Space(EditorGUIUtility.singleLineHeight + rectMargin);
            EditorGUI.EndDisabledGroup();

            // Draw a warning if safe search is turned off to notify the user about their poor judgement.
            if (!safeSearch.boolValue)
            {
                EditorGUILayout.HelpBox("Safe Search is turned off. Be aware that some types may not be compatible with all platforms.", MessageType.Warning);
            }

            //Draw the namespace field.
            EditorGUILayout.PropertyField(@namespace, new GUIContent("Namespace"));
            EditorGUILayout.Space(EditorGUIUtility.singleLineHeight);

            // Draw the options.
            EditorGUILayout.LabelField($"Options", EditorStyles.boldLabel);

            // Draw buttons to select all or none of the options immediately.
            EditorGUILayout.BeginHorizontal();
            {
                if (GUILayout.Button("All", GUILayout.ExpandWidth(false)))
                {
                    for (int i = 0; i < _options.arraySize; i++)
                    {
                        var option = _options.GetArrayElementAtIndex(i);
                        option.boolValue = true;
                    }
                }

                if (GUILayout.Button("None", GUILayout.ExpandWidth(false)))
                {
                    for (int i = 0; i < _options.arraySize; i++)
                    {
                        var option = _options.GetArrayElementAtIndex(i);
                        option.boolValue = false;
                    }
                }
            }
            EditorGUILayout.EndHorizontal();

            // Draw the different generator options and if a file has been generated, draw it in a disabled objectfield as well.
            for (int i = 0; i < _options.arraySize; i++)
            {
                var key = _keys.GetArrayElementAtIndex(i);
                var option = _options.GetArrayElementAtIndex(i);
                var script = _scripts.GetArrayElementAtIndex(i);

                var optionLabel = new GUIContent(key.stringValue);

                EditorGUILayout.BeginHorizontal();

                EditorGUILayout.PropertyField(option, optionLabel);

                EditorGUI.BeginDisabledGroup(true);
                EditorGUILayout.PropertyField(script, GUIContent.none);
                EditorGUI.EndDisabledGroup();

                EditorGUILayout.EndHorizontal();
            }

            serializedObject.ApplyModifiedProperties();

            // Draw the regenerate button.
            EditorGUILayout.Space(EditorGUIUtility.singleLineHeight);

            if (GUILayout.Button("(Re)Generate"))
            {
                generator.Generate();
            }
        }
    }
}
