using UnityEngine;
using UnityEditor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Make property read only by using the abbtribute `[ReadOnly]`. Solution taken from: https://answers.unity.com/questions/489942/how-to-make-a-readonly-property-in-inspector.html
    /// </summary>
    [CustomPropertyDrawer(typeof(ReadOnlyAttribute))]
    public class ReadOnlyDrawer : PropertyDrawer
    {
        public override float GetPropertyHeight(SerializedProperty property,
            GUIContent label)
        {
            return EditorGUI.GetPropertyHeight(property, label, true);
        }

        public override void OnGUI(Rect position,
            SerializedProperty property,
            GUIContent label)
        {
            GUI.enabled = false;
            EditorGUI.PropertyField(position, property, label, true);
            GUI.enabled = true;
        }
    }
}