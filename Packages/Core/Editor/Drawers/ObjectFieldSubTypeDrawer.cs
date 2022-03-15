using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace UnityAtoms.Editor
{
    [CustomPropertyDrawer(typeof(ObjectFieldSubType))]
    public class ObjectFieldSubTypeDrawer : PropertyDrawer
    {
        public override float GetPropertyHeight(SerializedProperty property,
          GUIContent label)
        {
            return EditorGUI.GetPropertyHeight(property, label, true);
        }

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            ObjectFieldSubType objectFieldSubType = (ObjectFieldSubType)attribute;

            if (property.serializedObject.isEditingMultipleObjects)
            {
                EditorGUI.PropertyField(position, property, label, true);
                return;
            }

            EditorGUI.BeginProperty(position, label, property);

            position = EditorGUI.PrefixLabel(position, GUIUtility.GetControlID(FocusType.Passive), label);

            var indent = EditorGUI.indentLevel;
            EditorGUI.indentLevel = 0;

            EditorGUI.ObjectField(position, property.objectReferenceValue, objectFieldSubType.SubType, false);

            EditorGUI.indentLevel = indent;
            EditorGUI.EndProperty();
        }
    }
}
