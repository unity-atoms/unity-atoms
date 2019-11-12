using UnityEditor;
using UnityEngine;

namespace UnityAtoms.Conditions
{
    [CustomPropertyDrawer(typeof(IntCondition))]
    public class IntConditionDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            // Using BeginProperty / EndProperty on the parent property means that
            // prefab override logic works on the entire property.
            EditorGUI.BeginProperty(position, label, property);

            // Draw label
            //position = EditorGUI.PrefixLabel(position, GUIUtility.GetControlID(FocusType.Passive), label);

            // Don't make child fields be indented
            var indent = EditorGUI.indentLevel;
            EditorGUI.indentLevel = 0;

            var referenceRect = new Rect(position.x, position.y, position.width * 0.4f, position.height);
            var conditionRect = new Rect(position.x + (position.width * 0.4f), position.y, position.width * 0.2f, position.height);
            var valueRect = new Rect(position.x + (position.width * 0.6f), position.y, position.width * 0.4f, position.height);


            // Draw fields - passs GUIContent.none to each so they are drawn without labels
            EditorGUI.PropertyField(referenceRect, property.FindPropertyRelative("Reference"), GUIContent.none);
            EditorGUI.PropertyField(conditionRect, property.FindPropertyRelative("ComparisonType"), GUIContent.none);
            EditorGUI.PropertyField(valueRect, property.FindPropertyRelative("Value"), GUIContent.none);

            // Set indent back to what it was
            EditorGUI.indentLevel = indent;

            EditorGUI.EndProperty();
        }
    }
}

