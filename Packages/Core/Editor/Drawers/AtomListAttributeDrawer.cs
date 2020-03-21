using UnityEditor;
using UnityEngine;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// A custom property drawer for properties using the `AtomList` attribute. 
    /// </summary>
    [CustomPropertyDrawer(typeof(AtomListAttribute))]
    public class AtomListAttributeDrawer : PropertyDrawer
    {
        static int INDEX_LABEL_WIDTH = 16;
        static int BUTTON_WIDTH = 24;
        static GUIContent PLUS_ICON = IconContent("Toolbar Plus", "Add entry");
        static GUIContent MINUS_ICON = IconContent("Toolbar Minus", "Remove entry");
        static float DRAWER_MARGIN = 6f;
        static float LINE_BOTTOM_MARGIN = 4f;
        static float GUTTER = 6f;
        static string SERIALIZED_LIST_PROPNAME = "_serializedList";
        static string LIST_LABEL_NAME = "List";

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            AtomListAttribute atomListAttr = attribute as AtomListAttribute;

            var propertyHeight = EditorGUIUtility.singleLineHeight + LINE_BOTTOM_MARGIN + DRAWER_MARGIN * 2f;
            var listProperty = property.FindPropertyRelative(atomListAttr != null && !string.IsNullOrWhiteSpace(atomListAttr.ChildPropName) ? atomListAttr.ChildPropName : SERIALIZED_LIST_PROPNAME);

            var length = listProperty.arraySize;
            for (var i = 0; i < length; ++i)
            {
                var itemProp = listProperty.GetArrayElementAtIndex(i);
                var itemPropHeight = EditorGUI.GetPropertyHeight(itemProp);
                propertyHeight += itemPropHeight + LINE_BOTTOM_MARGIN;
            }

            return propertyHeight;
        }

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            AtomListAttribute atomListAttr = attribute as AtomListAttribute;

            label = EditorGUI.BeginProperty(position, label, property);
            var proColor = new Color(83f / 255f, 83f / 255f, 83f / 255f);
            var basicColor = new Color(174f / 255f, 174f / 255f, 174f / 255f);
            EditorGUI.DrawRect(position, EditorGUIUtility.isProSkin ? proColor : basicColor);

            var indent = EditorGUI.indentLevel;
            EditorGUI.indentLevel = 0;
            EditorGUI.BeginChangeCheck();

            var listArrayProperty = property.FindPropertyRelative(atomListAttr != null && !string.IsNullOrWhiteSpace(atomListAttr.ChildPropName) ? atomListAttr.ChildPropName : SERIALIZED_LIST_PROPNAME);

            var restRect = new Rect();
            var initialPosition = new Rect(position);
            initialPosition.y = initialPosition.y + DRAWER_MARGIN;
            initialPosition.x = initialPosition.x + DRAWER_MARGIN;
            initialPosition.width = initialPosition.width - DRAWER_MARGIN * 2f;

            var labelPosition = IMGUIUtils.SnipRectH(initialPosition, initialPosition.width - BUTTON_WIDTH, out restRect);
            labelPosition.height = EditorGUIUtility.singleLineHeight + LINE_BOTTOM_MARGIN;
            EditorGUI.PrefixLabel(initialPosition, new GUIContent(atomListAttr != null ? (atomListAttr.Label ?? label.text) : LIST_LABEL_NAME));

            var addButtonPosition = IMGUIUtils.SnipRectH(restRect, restRect.width, out restRect);
            addButtonPosition.height = EditorGUIUtility.singleLineHeight;
            var insertIndex = -1;
            if (GUI.Button(addButtonPosition, PLUS_ICON))
            {
                insertIndex = listArrayProperty.arraySize;
            }

            var linePosition = new Rect(initialPosition);
            linePosition.height = EditorGUIUtility.singleLineHeight;
            linePosition.y += EditorGUIUtility.singleLineHeight + LINE_BOTTOM_MARGIN;

            var indexToDelete = -1;
            var length = listArrayProperty.arraySize;
            for (var i = 0; i < length; ++i)
            {
                var itemProp = listArrayProperty.GetArrayElementAtIndex(i);

                var indexLabelPos = IMGUIUtils.SnipRectH(linePosition, INDEX_LABEL_WIDTH, out restRect, GUTTER);
                EditorGUI.PrefixLabel(indexLabelPos, new GUIContent(i.ToString()));

                var itemPos = IMGUIUtils.SnipRectH(restRect, linePosition.width - BUTTON_WIDTH - INDEX_LABEL_WIDTH - GUTTER * 2, out restRect, GUTTER);
                EditorGUI.PropertyField(itemPos, itemProp, GUIContent.none, atomListAttr != null ? atomListAttr.IncludeChildrenForItems : false);

                var removeButtonPosition = new Rect(restRect);
                removeButtonPosition.height = EditorGUIUtility.singleLineHeight;

                if (GUI.Button(removeButtonPosition, MINUS_ICON))
                {
                    indexToDelete = i;
                }

                linePosition.y += EditorGUI.GetPropertyHeight(itemProp) + LINE_BOTTOM_MARGIN;
            }

            if (insertIndex != -1)
            {
                if (listArrayProperty != null)
                {
                    listArrayProperty.InsertArrayElementAtIndex(insertIndex);
                    var newProp = listArrayProperty.GetArrayElementAtIndex(insertIndex);
                    newProp.isExpanded = true;
                }
            }

            if (indexToDelete != -1)
            {
                if (listArrayProperty != null)
                {
                    listArrayProperty.RemoveArrayElement(indexToDelete);
                }
            }

            if (EditorGUI.EndChangeCheck())
                property.serializedObject.ApplyModifiedProperties();

            EditorGUI.indentLevel = indent;
            EditorGUI.EndProperty();
        }

        static GUIContent IconContent(string name, string tooltip)
        {
            var builtinIcon = EditorGUIUtility.IconContent(name);
            return new GUIContent(builtinIcon.image, tooltip);
        }
    }
}