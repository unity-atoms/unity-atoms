using UnityEditor;
using UnityEngine;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Property drawer To correct certain fields into the right Type. This is used in e.g. AtomList and AtomCollection.
    /// </summary>
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

            property.objectReferenceValue = EditorGUI.ObjectField(position, property.objectReferenceValue, objectFieldSubType.SubType, false);

            EditorGUI.indentLevel = indent;
            EditorGUI.EndProperty();
        }
    }
}
