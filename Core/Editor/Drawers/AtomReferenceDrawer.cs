using UnityEditor;
using UnityEngine;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// A custom property drawer for References. Makes it possible to choose between a Variable and a constant value (not a Atom Contant, but a regular value).
    /// </summary>

    [CustomPropertyDrawer(typeof(AtomReference), true)]
    public class AtomReferenceDrawer : PropertyDrawer
    {
        private static readonly string[] _popupOptions =
            { "Use Value", "Use Constant", "Use Variable" };
        private static GUIStyle _popupStyle;

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            SerializedProperty _usage = property.FindPropertyRelative("_usage");
            SerializedProperty _value = property.FindPropertyRelative("_value");
            SerializedProperty _constant = property.FindPropertyRelative("_constant");
            SerializedProperty _variable = property.FindPropertyRelative("_variable");

            var usage = (AtomReference.Usage)_usage.intValue;
            var valueToUse = usage == AtomReference.Usage.Value ? _value : usage == AtomReference.Usage.Constant ? _constant : _variable;

            return EditorGUI.GetPropertyHeight(valueToUse, label);
        }

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            if (_popupStyle == null)
            {
                _popupStyle = new GUIStyle(GUI.skin.GetStyle("PaneOptions"));
                _popupStyle.imagePosition = ImagePosition.ImageOnly;
            }

            label = EditorGUI.BeginProperty(position, label, property);
            position = EditorGUI.PrefixLabel(position, label);

            EditorGUI.BeginChangeCheck();

            // Get properties
            SerializedProperty _usage = property.FindPropertyRelative("_usage");
            SerializedProperty _value = property.FindPropertyRelative("_value");
            SerializedProperty _constant = property.FindPropertyRelative("_constant");
            SerializedProperty _variable = property.FindPropertyRelative("_variable");

            // Calculate rect for configuration button
            Rect buttonRect = new Rect(position);
            buttonRect.yMin += _popupStyle.margin.top;
            buttonRect.width = _popupStyle.fixedWidth + _popupStyle.margin.right;
            position.xMin = buttonRect.xMax;

            // Store old indent level and set it to 0, the PrefixLabel takes care of it
            int indent = EditorGUI.indentLevel;
            EditorGUI.indentLevel = 0;
            _usage.intValue = EditorGUI.Popup(buttonRect, _usage.intValue, _popupOptions, _popupStyle);
            var usage = (AtomReference.Usage)_usage.intValue;

            var valueToUse = usage == AtomReference.Usage.Value ? _value : usage == AtomReference.Usage.Constant ? _constant : _variable;

            EditorGUI.PropertyField(position,
                valueToUse,
                GUIContent.none);

            if (EditorGUI.EndChangeCheck())
                property.serializedObject.ApplyModifiedProperties();

            EditorGUI.indentLevel = indent;
            EditorGUI.EndProperty();
        }




    }
}
