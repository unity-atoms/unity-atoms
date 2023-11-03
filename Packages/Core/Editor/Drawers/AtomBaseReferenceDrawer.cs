using System.Linq;
using UnityEditor;
using UnityEngine;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// A custom property drawer for References (Events and regular). Makes it possible to reference a resources (Variable or Event) through multiple options.
    /// </summary>

    public abstract class AtomBaseReferenceDrawer<TInstancerType> : PropertyDrawer
        where TInstancerType : MonoBehaviour
    {
        protected abstract class UsageData
        {
            public abstract int Value { get; }
            public abstract string PropertyName { get; }
            public abstract string DisplayName { get; }
        }
        const string USAGE_PROPERTY_NAME = "_usage";

        protected abstract UsageData[] GetUsages(SerializedProperty prop = null);

        private string[] GetPopupOptions(SerializedProperty prop = null) => GetUsages(prop).Select(u => u.DisplayName).ToArray();
        private static GUIStyle _popupStyle;

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            var usageIntVal = property.FindPropertyRelative(USAGE_PROPERTY_NAME).intValue;
            var usageData = GetUsages(property)[0];
            for (var i = 0; i < GetUsages(property).Length; ++i)
            {
                if (GetUsages(property)[i].Value == usageIntVal)
                {
                    usageData = GetUsages(property)[i];
                    break;
                }
            }

            var innerProperty = property.FindPropertyRelative(usageData.PropertyName);
            return innerProperty == null ?
                EditorGUIUtility.singleLineHeight :
                EditorGUI.GetPropertyHeight(innerProperty, label);
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

            // Calculate rect for configuration button
            Rect buttonRect = new Rect(position);
            buttonRect.yMin += _popupStyle.margin.top;
            buttonRect.yMax = buttonRect.yMin + EditorGUIUtility.singleLineHeight;
            buttonRect.width = _popupStyle.fixedWidth + _popupStyle.margin.right;
            position.xMin = buttonRect.xMax;

            // Store old indent level and set it to 0, the PrefixLabel takes care of it
            int indent = EditorGUI.indentLevel;
            EditorGUI.indentLevel = 0;

            var currentUsage = property.FindPropertyRelative(USAGE_PROPERTY_NAME);
            var newUsageValue = EditorGUI.Popup(buttonRect, currentUsage.intValue, GetPopupOptions(property), _popupStyle);
            DetermineDragAndDropFieldReferenceType(position, property, ref newUsageValue);
            currentUsage.intValue = newUsageValue;

            var usageTypePropertyName = GetUsages(property)[newUsageValue].PropertyName;
            var usageTypeProperty = property.FindPropertyRelative(usageTypePropertyName);

            if (usageTypeProperty == null)
            {
                EditorGUI.LabelField(position, "[Non serialized value]");
            }
            else
            {
                var expanded = usageTypeProperty.isExpanded;
                usageTypeProperty.isExpanded = true;
                var valueFieldHeight = EditorGUI.GetPropertyHeight(usageTypeProperty, label);
                usageTypeProperty.isExpanded = expanded;

                if (usageTypePropertyName == "_value" && (valueFieldHeight > EditorGUIUtility.singleLineHeight + 2))
                {
                    EditorGUI.PropertyField(originalPosition, usageTypeProperty, GUIContent.none, true);
                }
                else
                {
                    EditorGUI.PropertyField(position, usageTypeProperty, GUIContent.none);
                }
            }
            if (EditorGUI.EndChangeCheck())
                property.serializedObject.ApplyModifiedProperties();

            EditorGUI.indentLevel = indent;
            EditorGUI.EndProperty();
        }

        #region Auto DragAndDrop UsageTypeDetection
        private void DetermineDragAndDropFieldReferenceType(in Rect position, SerializedProperty property,
            ref int newUsageValue)
        {
            EventType mouseEventType = Event.current.type;

            if (mouseEventType != EventType.DragUpdated && mouseEventType != EventType.DragPerform)
                return;

            if (!IsMouseHoveringOverProperty(position))
                return;

            var draggedObjects = DragAndDrop.objectReferences;

            if (draggedObjects.Length < 1)
                return;

            Object draggedObject = draggedObjects[0];

            if (draggedObject is GameObject gameObject)
                draggedObject = gameObject.GetComponent<TInstancerType>();

            UpdateConfigurationOption(property, draggedObject, ref newUsageValue);
        }

        private void UpdateConfigurationOption(SerializedProperty property, Object draggedObject, ref int newUsageValue)
        {
            if (!draggedObject)
                return;

            var usages = GetUsages(property);

            for (int index = 0; index < usages.Length; index++)
            {
                var usage = usages[index];
                SerializedProperty fieldProperty = property.FindPropertyRelative(usage.PropertyName);
                string draggedObjectType = draggedObject.GetType().Name;
                string fieldPropertyType = fieldProperty.type.Replace("PPtr<$", "").Replace(">", "");

                if (draggedObjectType == fieldPropertyType)
                {
                    newUsageValue = index;
                    break;
                }
            }
        }

        private static bool IsMouseHoveringOverProperty(Rect rectPosition)
        {
            const int HEIGHT_OFFSET_TO_AVOID_OVERLAP = 1;
            Rect controlRect = rectPosition;
            controlRect.height -= HEIGHT_OFFSET_TO_AVOID_OVERLAP;

            return controlRect.Contains(Event.current.mousePosition);
        }
        #endregion
        
    }
}
