using System;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEditor.Compilation;
using UnityEngine;
using Assembly = System.Reflection.Assembly;

namespace UnityAtoms.Editor
{
    [CustomEditor(typeof(AtomGenerator))]
    public class AtomGeneratorEditor : UnityEditor.Editor
    {
        private TypeSelectorDropdown typeSelectorDropdown;

        private SerializedProperty assemblyQualifiedName;
        private SerializedProperty withNamespace;
        private SerializedProperty options;
        private SerializedProperty scripts;
        private SerializedProperty keys;
        private SerializedProperty safeSearch;

        private void OnEnable()
        {
            // Find Properties.
            assemblyQualifiedName = serializedObject.FindProperty(nameof(AtomGenerator.assemblyQualifiedName));
            withNamespace = serializedObject.FindProperty(nameof(AtomGenerator.withNamespace));
            options = serializedObject.FindProperty(nameof(AtomGenerator.options));
            scripts = serializedObject.FindProperty(nameof(AtomGenerator.scripts));
            keys = serializedObject.FindProperty(nameof(AtomGenerator.keys));
            safeSearch = serializedObject.FindProperty(nameof(safeSearch));

            UpdateOptions();

            RefreshDropdown();
        }

        private void UpdateOptions()
        {
            var resolverKeys = AtomGenerator.resolvers.Keys.ToArray();
            for (int i = keys.arraySize - 1; i >= 0; i--)
            {
                var key = keys.GetArrayElementAtIndex(i);

                var keyIndex = Array.IndexOf(resolverKeys, key.stringValue);
                if (keyIndex == -1)
                {
                    var srcIndex = i;
                    for (int dstIndex = srcIndex + 1; dstIndex < keys.arraySize; dstIndex++)
                    {
                        options.MoveArrayElement(srcIndex, dstIndex);
                        scripts.MoveArrayElement(srcIndex, dstIndex);
                        keys.MoveArrayElement(srcIndex, dstIndex);

                        srcIndex++;
                    }
                    options.DeleteArrayElementAtIndex(srcIndex);
                    scripts.DeleteArrayElementAtIndex(srcIndex);
                    keys.DeleteArrayElementAtIndex(srcIndex);
                }
            }

            keys.arraySize =
                 options.arraySize =
                 scripts.arraySize =
                 resolverKeys.Length;

            for (int i = 0; i < resolverKeys.Length; i++)
            {
                var resolverKey = resolverKeys[i];
                var key = keys.GetArrayElementAtIndex(i);

                if(key.stringValue != resolverKey)
                {
                    var option = options.GetArrayElementAtIndex(i);
                    var script = scripts.GetArrayElementAtIndex(i);

                    key.stringValue = resolverKey;
                    option.boolValue = false;
                    script.objectReferenceValue = null;
                }
            }

            serializedObject.ApplyModifiedPropertiesWithoutUndo();
        }

        public void RefreshDropdown()
        {
            // Search Player assemblies only if safe searching, else search all assemblies.
            IEnumerable<Assembly> assemblies;
            if(safeSearch.boolValue)
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
            if(safeSearch.boolValue)
            {
                types = from type in types
                        where type.IsUnitySerializable()
                        select type;
            }

            // Create a type selector dropdown that sets properties when something is selected.
            typeSelectorDropdown = new TypeSelectorDropdown(types, selectedType =>
            {
                serializedObject.Update();

                assemblyQualifiedName.stringValue = selectedType.AssemblyQualifiedName;

                serializedObject.ApplyModifiedProperties();
            });
        }

        public override void OnInspectorGUI()
        {
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

                EditorGUI.BeginChangeCheck();
                EditorGUI.PropertyField(toggleRect, safeSearch, GUIContent.none);
                //safeSearch = EditorGUI.Toggle(toggleRect, safeSearch);
                if (EditorGUI.EndChangeCheck())
                {
                    RefreshDropdown();
                }

                if (GUI.Button(buttonRect, buttonContent))
                {
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
            EditorGUI.TextField(typeRect, Type.GetType(assemblyQualifiedName.stringValue)?.FullName);
            EditorGUILayout.Space(EditorGUIUtility.singleLineHeight + rectMargin);
            EditorGUI.EndDisabledGroup();

            // Draw a warning if safe search is turned off to notify the user about their poor judgement.
            if (!safeSearch.boolValue)
            {
                EditorGUILayout.HelpBox("Safe Search is turned off. Be aware that some types may not be compatible with all platforms.", MessageType.Warning);
            }

            //Draw the namespace field.
            EditorGUILayout.PropertyField(withNamespace, new GUIContent("Namespace"));
            EditorGUILayout.Space(EditorGUIUtility.singleLineHeight);

            // Draw the different generator options and if a file has been generated, draw it in a disabled objectfield as well.
            EditorGUILayout.LabelField($"Options", EditorStyles.boldLabel);

            for(int i = 0; i < keys.arraySize; i++)
            {
                var option = options.GetArrayElementAtIndex(i);
                var script = scripts.GetArrayElementAtIndex(i);
                var key = keys.GetArrayElementAtIndex(i);

                var optionLabel = new GUIContent(key.stringValue);

                EditorGUILayout.BeginHorizontal();

                EditorGUILayout.PropertyField(option, optionLabel);
                EditorGUILayout.PropertyField(script, GUIContent.none);

                EditorGUILayout.EndHorizontal();
            }

            serializedObject.ApplyModifiedProperties();

            EditorGUI.BeginDisabledGroup(string.IsNullOrEmpty(assemblyQualifiedName.stringValue));
            if (GUILayout.Button("(Re)Generate"))
            {
                (target as AtomGenerator).Generate();
                AssetDatabase.SaveAssets();
            }
            EditorGUI.EndDisabledGroup();
            if (string.IsNullOrEmpty(assemblyQualifiedName.stringValue))
            {
                EditorGUILayout.HelpBox("You must pick a type before you may generate atoms.", MessageType.Error);
            }
        }
    }
}
