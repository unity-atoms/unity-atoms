using System.Linq;
using UnityEditor;
using UnityEngine;

namespace UnityAtoms.Editor
{
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

            return EditorGUI.GetPropertyHeight(property.FindPropertyRelative(usageData.PropertyName), label);
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
            usage.intValue = GetUsages(property)[newUsagePopupIndex].Value;

            EditorGUI.PropertyField(position,
                property.FindPropertyRelative(GetUsages(property)[newUsagePopupIndex].PropertyName),
                GUIContent.none);

            if (EditorGUI.EndChangeCheck())
                property.serializedObject.ApplyModifiedProperties();

            EditorGUI.indentLevel = indent;
            EditorGUI.EndProperty();
        }
    }
}
