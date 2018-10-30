using UnityEditor;
using UnityEngine;

namespace UnityAtoms
{
    public abstract class ReferenceDrawer : PropertyDrawer
    {
        private readonly string[] popupOptions =
            { "Use Constant", "Use Variable" };

        private GUIStyle popupStyle;

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            if (popupStyle == null)
            {
                popupStyle = new GUIStyle(GUI.skin.GetStyle("PaneOptions"));
                popupStyle.imagePosition = ImagePosition.ImageOnly;
            }

            label = EditorGUI.BeginProperty(position, label, property);
            position = EditorGUI.PrefixLabel(position, label);

            EditorGUI.BeginChangeCheck();

            // Get properties
            SerializedProperty useConstant = property.FindPropertyRelative("UseConstant");
            SerializedProperty constantValue = property.FindPropertyRelative("ConstantValue");
            SerializedProperty variable = property.FindPropertyRelative("Variable");

            // Calculate rect for configuration button
            Rect buttonRect = new Rect(position);
            buttonRect.yMin += popupStyle.margin.top;
            buttonRect.width = popupStyle.fixedWidth + popupStyle.margin.right;
            position.xMin = buttonRect.xMax;

            // Store old indent level and set it to 0, the PrefixLabel takes care of it
            int indent = EditorGUI.indentLevel;
            EditorGUI.indentLevel = 0;

            int result = EditorGUI.Popup(buttonRect, useConstant.boolValue ? 0 : 1, popupOptions, popupStyle);

            useConstant.boolValue = result == 0;

            EditorGUI.PropertyField(position,
                useConstant.boolValue ? constantValue : variable,
                GUIContent.none);

            if (EditorGUI.EndChangeCheck())
                property.serializedObject.ApplyModifiedProperties();

            EditorGUI.indentLevel = indent;
            EditorGUI.EndProperty();
        }

        [CustomPropertyDrawer(typeof(BoolReference))]
        public class BoolReferenceDrawer : ReferenceDrawer { }

        [CustomPropertyDrawer(typeof(ColorReference))]
        public class ColorReferenceDrawer : ReferenceDrawer { }

        [CustomPropertyDrawer(typeof(FloatReference))]
        public class FloatReferenceDrawer : ReferenceDrawer { }

        [CustomPropertyDrawer(typeof(IntReference))]
        public class IntReferenceDrawer : ReferenceDrawer { }

        [CustomPropertyDrawer(typeof(Vector2Reference))]
        public class Vector2ReferenceDrawer : ReferenceDrawer { }

        [CustomPropertyDrawer(typeof(Vector3Reference))]
        public class Vector3ReferenceDrawer : ReferenceDrawer { }
    }
}