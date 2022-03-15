using System;
using System.Linq;
using UnityEditor;
using UnityEngine;

namespace UnityAtoms.Editor
{
    [CustomPropertyDrawer(typeof(HideCreate))]
    public class HideCreateDrawer : PropertyDrawer
    {
        public override float GetPropertyHeight(SerializedProperty property,
           GUIContent label)
        {
            return EditorGUI.GetPropertyHeight(property, label, true);
        }

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            if (property.serializedObject.isEditingMultipleObjects)
            {
                EditorGUI.PropertyField(position, property, label, true);
                return;
            }

            EditorGUI.BeginProperty(position, label, property);

            position = EditorGUI.PrefixLabel(position, GUIUtility.GetControlID(FocusType.Passive), label);

            var indent = EditorGUI.indentLevel;
            EditorGUI.indentLevel = 0;

            EditorGUI.ObjectField(position, property.objectReferenceValue, GetAtomEventType(), false);
            
            EditorGUI.indentLevel = indent;
            EditorGUI.EndProperty();
        }

        private Type GetAtomEventType()
        {
            if (TypeCache.GetTypesDerivedFrom(fieldInfo.FieldType).Count != 0)
            {
                return TypeCache.GetTypesDerivedFrom(fieldInfo.FieldType).First();
            }
            else
            {
                return TypeCache.GetTypesDerivedFrom(fieldInfo.FieldType.BaseType).First();
            }
        }
    }
}

