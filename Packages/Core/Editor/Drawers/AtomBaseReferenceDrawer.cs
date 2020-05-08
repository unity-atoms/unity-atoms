using System.Linq;
using UnityEditor;
using UnityEngine;

namespace UnityAtoms.Editor
{
    using Editor = UnityEditor.Editor;

    /// <summary>
    /// A custom property drawer for References (Events and regular). Makes it possible to reference a resources (Variable or Event) through multiple options.
    /// </summary>

    public abstract class AtomBaseReferenceDrawer : PropertyDrawer
    {
        protected abstract class UsageData
        {
            public abstract int Value { get; }
            public abstract string PropertyName { get; }
            public abstract string DisplayName { get; }
        }

        protected abstract UsageData[] GetUsages(SerializedProperty prop = null);

        private string[] GetPopupOptions(SerializedProperty prop = null) => GetUsages(prop).Select(u => u.DisplayName).ToArray();
        private static GUIStyle _popupStyle;

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            var usageIntVal = property.FindPropertyRelative("_usage").intValue;
            var usageData = GetUsages(property)[0];
            for (var i = 0; i < GetUsages(property).Length; ++i)
            {
                if (GetUsages(property)[i].Value == usageIntVal)
                {
                    usageData = GetUsages(property)[i];
                    break;
                }
            }

            float propertyHeight = EditorGUI.GetPropertyHeight(property.FindPropertyRelative(usageData.PropertyName), label);

            // ----- Proposal 2 ----- //
            // if (usageIntVal == 0)
            // {
            //     propertyHeight += EditorGUIUtility.singleLineHeight;
            // }

            return propertyHeight;
        }

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            if (_popupStyle == null)
            {
                _popupStyle = new GUIStyle(GUI.skin.GetStyle("PaneOptions"));
                _popupStyle.imagePosition = ImagePosition.ImageOnly;
            }

            Rect originalPosition = new Rect(position);

            label = EditorGUI.BeginProperty(position, label, property);
            position = EditorGUI.PrefixLabel(position, label);

            EditorGUI.BeginChangeCheck();

            var usage = property.FindPropertyRelative("_usage");
            int usagePopupIndex = 0;
            for (var i = 0; i < GetUsages(property).Length; ++i)
            {
                if (GetUsages(property)[i].Value == usage.intValue)
                {
                    usagePopupIndex = i;
                    break;
                }
            }

            // Calculate rect for configuration button
            Rect buttonRect = new Rect(position);
            buttonRect.yMin += _popupStyle.margin.top;
            buttonRect.width = _popupStyle.fixedWidth + _popupStyle.margin.right;
            position.xMin = buttonRect.xMax;

            // Store old indent level and set it to 0, the PrefixLabel takes care of it
            int indent = EditorGUI.indentLevel;
            EditorGUI.indentLevel = 0;
            var newUsagePopupIndex = EditorGUI.Popup(buttonRect, usagePopupIndex, GetPopupOptions(property), _popupStyle);

            int usageType = GetUsages(property)[newUsagePopupIndex].Value;
            usage.intValue = usageType;

            if (usageType == 0)
            {
                // ----- Proposal 1 ----- //
                // EditorGUI.PropertyField(originalPosition,
                //     property.FindPropertyRelative(GetUsages(property)[newUsagePopupIndex].PropertyName),
                //     GUIContent.none, true);

                // ----- Proposal 1 extra ----- //
                SerializedProperty valueProperty =
                    property.FindPropertyRelative(GetUsages(property)[newUsagePopupIndex].PropertyName);
                if (valueProperty.hasChildren)
                {
                    EditorGUI.PropertyField(originalPosition,
                        property.FindPropertyRelative(GetUsages(property)[newUsagePopupIndex].PropertyName),
                        GUIContent.none, true);
                }
                else
                {
                    // Can be refactored
                    EditorGUI.PropertyField(position,
                        property.FindPropertyRelative(GetUsages(property)[newUsagePopupIndex].PropertyName),
                        GUIContent.none);
                }

                // ----- Proposal 2 ----- //
                // EditorGUI.indentLevel = 1;
                // originalPosition.y += EditorGUIUtility.singleLineHeight;
                // EditorGUI.PropertyField(originalPosition,
                //     property.FindPropertyRelative(GetUsages(property)[newUsagePopupIndex].PropertyName),
                //     new GUIContent("Value"), true);

                // ----- Proposal 2 extra ----- //
                // EditorGUI.indentLevel = 0;
                // GUI.enabled = false;
                // position.height = EditorGUIUtility.singleLineHeight;
                // EditorGUI.TextField(position, "Value used");
                // GUI.enabled = true;
            }
            else
            {
                EditorGUI.PropertyField(position,
                    property.FindPropertyRelative(GetUsages(property)[newUsagePopupIndex].PropertyName),
                    GUIContent.none);
            }

            if (EditorGUI.EndChangeCheck())
                property.serializedObject.ApplyModifiedProperties();

            EditorGUI.indentLevel = indent;
            EditorGUI.EndProperty();
        }
    }
}
