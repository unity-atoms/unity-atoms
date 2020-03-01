using UnityEditor;
using UnityEngine;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// A custom property drawer for Event References. Makes it possible to choose between an Event, Variable or a Variable Instancer.
    /// </summary>
    [CustomPropertyDrawer(typeof(AtomEventReferenceBase), true)]
    public class AtomEventReferenceDrawer : PropertyDrawer
    {
        private static readonly string[] _popupOptions =
            { "Use Event", "Use Event Instancer", "Use Variable", "Use Variable Instancer" };
        private static GUIStyle _popupStyle;

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            SerializedProperty usage = property.FindPropertyRelative("_usage");
            SerializedProperty ev = property.FindPropertyRelative("_event");
            SerializedProperty evInstancer = property.FindPropertyRelative("_eventInstancer");
            SerializedProperty variable = property.FindPropertyRelative("_variable");
            SerializedProperty variableInstancer = property.FindPropertyRelative("_variableInstancer");

            return EditorGUI.GetPropertyHeight(GetPropToUse(usage, ev, evInstancer, variable, variableInstancer), label);
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
            SerializedProperty usage = property.FindPropertyRelative("_usage");
            SerializedProperty ev = property.FindPropertyRelative("_event");
            SerializedProperty evInstancer = property.FindPropertyRelative("_eventInstancer");
            SerializedProperty variable = property.FindPropertyRelative("_variable");
            SerializedProperty variableInstancer = property.FindPropertyRelative("_variableInstancer");

            // Calculate rect for configuration button
            Rect buttonRect = new Rect(position);
            buttonRect.yMin += _popupStyle.margin.top;
            buttonRect.width = _popupStyle.fixedWidth + _popupStyle.margin.right;
            position.xMin = buttonRect.xMax;

            // Store old indent level and set it to 0, the PrefixLabel takes care of it
            int indent = EditorGUI.indentLevel;
            EditorGUI.indentLevel = 0;
            usage.intValue = EditorGUI.Popup(buttonRect, usage.intValue, _popupOptions, _popupStyle);

            EditorGUI.PropertyField(position,
                GetPropToUse(usage, ev, evInstancer, variable, variableInstancer),
                GUIContent.none);

            if (EditorGUI.EndChangeCheck())
                property.serializedObject.ApplyModifiedProperties();

            EditorGUI.indentLevel = indent;
            EditorGUI.EndProperty();
        }

        private SerializedProperty GetPropToUse(SerializedProperty usage, SerializedProperty ev, SerializedProperty evInstancer, SerializedProperty variable, SerializedProperty variableInstancer)
        {
            var usageIntVal = (AtomEventReferenceBase.Usage)usage.intValue;
            if (usageIntVal == AtomEventReferenceBase.Usage.Variable)
            {
                return variable;
            }
            else if (usageIntVal == AtomEventReferenceBase.Usage.EventInstancer)
            {
                return evInstancer;
            }
            else if (usageIntVal == AtomEventReferenceBase.Usage.VariableInstancer)
            {
                return variableInstancer;
            }
            else  // if (usageIntVal == AtomEventReferenceBase.Usage.Event)
            {
                return ev;
            }
        }


    }
}
