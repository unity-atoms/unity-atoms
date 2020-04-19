using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// A custom property drawer for SerializableDictionary. 
    /// </summary>
    public abstract class SerializableDictionaryDrawer<K, V, T> : PropertyDrawer
        where K : IEquatable<K>
        where T : SerializableDictionary<K, V>
    {
        static int BUTTON_WIDTH = 24;
        static GUIContent PLUS_ICON = IconContent("Toolbar Plus", "Add entry");
        static GUIContent MINUS_ICON = IconContent("Toolbar Minus", "Remove entry");
        static float DRAWER_MARGIN = 6f;
        static float LINE_BOTTOM_MARGIN = 4f;
        static float GUTTER = 6f;
        static string WARNING_TEXT = "There are 1 or more duplicate keys. Duplicate keys are marked in red, are only shown in the editor and not included in the collection itself.";
        static string SERIALIZED_KEYS_PROPNAME = "_serializedKeys";
        static string SERIALIZED_VALUES_PROPNAME = "_serializedValues";
        static string DUPLICATE_KEY_INDICES_PROPNAME = "_duplicateKeyIndices";
        static string COLLECTION_LABEL_NAME = "Collection";

        class DrawerData
        {
            public bool InvalidKeyExists = false;
        }

        private Dictionary<string, DrawerData> _perPropertyViewData = new Dictionary<string, DrawerData>();

        private DrawerData GetDrawerData(string propertyPath)
        {
            DrawerData drawerData;
            if (!_perPropertyViewData.TryGetValue(propertyPath, out drawerData))
            {
                drawerData = new DrawerData();
                _perPropertyViewData[propertyPath] = drawerData;
            }
            return drawerData;
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            var propertyHeight = EditorGUIUtility.singleLineHeight + LINE_BOTTOM_MARGIN + DRAWER_MARGIN * 2f;
            var keysProperty = property.FindPropertyRelative(SERIALIZED_KEYS_PROPNAME);
            var valuesProperty = property.FindPropertyRelative(SERIALIZED_VALUES_PROPNAME);

            foreach (var entry in EnumerateEntries(keysProperty, valuesProperty))
            {
                var keyProperty = entry.keyProperty;
                var valueProperty = entry.valueProperty;
                float keyPropertyHeight = EditorGUI.GetPropertyHeight(keyProperty);
                float valuePropertyHeight = valueProperty != null ? EditorGUI.GetPropertyHeight(valueProperty) : 0f;
                float lineHeight = Mathf.Max(keyPropertyHeight, valuePropertyHeight) + LINE_BOTTOM_MARGIN;
                propertyHeight += lineHeight;
            }

            if (GetDrawerData(property.propertyPath).InvalidKeyExists)
            {
                propertyHeight += GetHelpboxHeight();
            }

            return propertyHeight;
        }

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            label = EditorGUI.BeginProperty(position, label, property);
            var proColor = new Color(83f / 255f, 83f / 255f, 83f / 255f);
            var basicColor = new Color(174f / 255f, 174f / 255f, 174f / 255f);
            EditorGUI.DrawRect(position, EditorGUIUtility.isProSkin ? proColor : basicColor);

            var indent = EditorGUI.indentLevel;
            EditorGUI.indentLevel = 0;
            EditorGUI.BeginChangeCheck();

            var keyArrayProperty = property.FindPropertyRelative(SERIALIZED_KEYS_PROPNAME);
            var valueArrayProperty = property.FindPropertyRelative(SERIALIZED_VALUES_PROPNAME);
            var duplicateKeyIndices = property.FindPropertyRelative(DUPLICATE_KEY_INDICES_PROPNAME);

            var restRect = new Rect();
            var initialPosition = new Rect(position);
            initialPosition.y = initialPosition.y + DRAWER_MARGIN;
            initialPosition.x = initialPosition.x + DRAWER_MARGIN;
            initialPosition.width = initialPosition.width - DRAWER_MARGIN * 2f;

            var labelPosition = IMGUIUtils.SnipRectH(initialPosition, initialPosition.width - BUTTON_WIDTH, out restRect);
            labelPosition.height = EditorGUIUtility.singleLineHeight + LINE_BOTTOM_MARGIN;
            EditorGUI.PrefixLabel(initialPosition, new GUIContent(COLLECTION_LABEL_NAME));

            var addButtonPosition = IMGUIUtils.SnipRectH(restRect, restRect.width, out restRect);
            addButtonPosition.height = EditorGUIUtility.singleLineHeight;
            var insertIndex = -1;
            if (GUI.Button(addButtonPosition, PLUS_ICON))
            {
                insertIndex = keyArrayProperty.arraySize;
            }

            var linePosition = new Rect(initialPosition);
            linePosition.height = EditorGUIUtility.singleLineHeight;
            linePosition.y += EditorGUIUtility.singleLineHeight + LINE_BOTTOM_MARGIN;

            var indexToDelete = -1;
            var invalidKeyExists = false;
            foreach (var entry in EnumerateEntries(keyArrayProperty, valueArrayProperty))
            {
                var keyProperty = entry.keyProperty;
                var valueProperty = entry.valueProperty;
                var currentIndex = entry.index;
                var isKeyValid = !duplicateKeyIndices.ArrayContainsInt(currentIndex);

                var keyPosition = IMGUIUtils.SnipRectH(linePosition, (linePosition.width - BUTTON_WIDTH - GUTTER * 2) / 2, out restRect, GUTTER);
                if (!isKeyValid)
                {
                    invalidKeyExists = true;
                    EditorGUI.DrawRect(keyPosition, Color.red);
                }
                EditorGUI.PropertyField(keyPosition, keyProperty, GUIContent.none, false);

                EditorGUI.BeginDisabledGroup(!isKeyValid);
                var valuePosition = IMGUIUtils.SnipRectH(restRect, (linePosition.width - BUTTON_WIDTH - GUTTER * 2) / 2, out restRect, GUTTER);
                EditorGUI.PropertyField(valuePosition, valueProperty, GUIContent.none, false);
                EditorGUI.EndDisabledGroup();

                var removeButtonPosition = new Rect(restRect);
                removeButtonPosition.height = EditorGUIUtility.singleLineHeight;

                if (GUI.Button(removeButtonPosition, MINUS_ICON))
                {
                    indexToDelete = currentIndex;
                }

                linePosition.y += EditorGUIUtility.singleLineHeight + LINE_BOTTOM_MARGIN;
            }

            var drawerData = GetDrawerData(property.propertyPath);
            drawerData.InvalidKeyExists = invalidKeyExists;
            if (invalidKeyExists)
            {
                linePosition.height = GetHelpboxHeight();
                EditorGUI.HelpBox(linePosition, WARNING_TEXT, MessageType.Error);
            }

            if (insertIndex != -1)
            {
                if (keyArrayProperty != null)
                {
                    keyArrayProperty.InsertArrayElementAtIndex(insertIndex);
                }

                if (valueArrayProperty != null)
                {
                    valueArrayProperty.InsertArrayElementAtIndex(insertIndex);
                }
            }

            if (indexToDelete != -1)
            {
                if (keyArrayProperty != null)
                {
                    keyArrayProperty.RemoveArrayElement(indexToDelete);
                }

                if (valueArrayProperty != null)
                {
                    valueArrayProperty.RemoveArrayElement(indexToDelete);
                }
            }

            if (EditorGUI.EndChangeCheck())
                property.serializedObject.ApplyModifiedProperties();

            EditorGUI.indentLevel = indent;
            EditorGUI.EndProperty();
        }

        static GUIContent IconContent(string name, string tooltip)
        {
            var builtinIcon = EditorGUIUtility.IconContent(name);
            return new GUIContent(builtinIcon.image, tooltip);
        }

        struct EnumerationEntry
        {
            public SerializedProperty keyProperty;
            public SerializedProperty valueProperty;
            public int index;

            public EnumerationEntry(SerializedProperty keyProperty, SerializedProperty valueProperty, int index)
            {
                this.keyProperty = keyProperty;
                this.valueProperty = valueProperty;
                this.index = index;
            }
        }

        static IEnumerable<EnumerationEntry> EnumerateEntries(SerializedProperty keyArrayProperty, SerializedProperty valueArrayProperty, int startIndex = 0)
        {
            if (keyArrayProperty.arraySize > startIndex)
            {
                var index = startIndex;
                var keyProperty = keyArrayProperty.GetArrayElementAtIndex(startIndex);
                var valueProperty = valueArrayProperty != null ? valueArrayProperty.GetArrayElementAtIndex(startIndex) : null;
                var endProperty = keyArrayProperty.GetEndProperty();

                do
                {
                    yield return new EnumerationEntry(keyProperty, valueProperty, index);
                    index++;
                } while (keyProperty.Next(false) && (valueProperty != null ? valueProperty.Next(false) : true) && !SerializedProperty.EqualContents(keyProperty, endProperty));
            }
        }

        private float GetHelpboxHeight()
        {
            if (EditorGUIUtility.currentViewWidth <= 388f)
            {
                return EditorGUIUtility.singleLineHeight * 3f;
            }

            return EditorGUIUtility.singleLineHeight * 2f;
        }
    }
}