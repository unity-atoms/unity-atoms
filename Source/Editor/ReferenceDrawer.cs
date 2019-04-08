using UnityEditor;
using UnityEngine;

namespace UnityAtoms
{
    public abstract class ReferenceDrawer : PropertyDrawer
    {
        private static readonly string[] PopupOptions =
            { "Use Constant", "Use Variable" };

        private static GUIStyle PopupStyle;

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            if (PopupStyle == null)
            {
                PopupStyle = new GUIStyle(GUI.skin.GetStyle("PaneOptions"));
                PopupStyle.imagePosition = ImagePosition.ImageOnly;
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
            buttonRect.yMin += PopupStyle.margin.top;
            buttonRect.width = PopupStyle.fixedWidth + PopupStyle.margin.right;
            position.xMin = buttonRect.xMax;

            // Store old indent level and set it to 0, the PrefixLabel takes care of it
            int indent = EditorGUI.indentLevel;
            EditorGUI.indentLevel = 0;

            int result = EditorGUI.Popup(buttonRect, useConstant.boolValue ? 0 : 1, PopupOptions, PopupStyle);

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
        public sealed class BoolReferenceDrawer : ReferenceDrawer { }

        [CustomPropertyDrawer(typeof(ColorReference))]
        public sealed class ColorReferenceDrawer : ReferenceDrawer { }

        [CustomPropertyDrawer(typeof(FloatReference))]
        public sealed class FloatReferenceDrawer : ReferenceDrawer { }

        [CustomPropertyDrawer(typeof(IntReference))]
        public sealed class IntReferenceDrawer : ReferenceDrawer { }

        [CustomPropertyDrawer(typeof(StringReference))]
        public sealed class StringReferenceDrawer : ReferenceDrawer { }

        [CustomPropertyDrawer(typeof(Vector2Reference))]
        public sealed class Vector2ReferenceDrawer : ReferenceDrawer { }

        [CustomPropertyDrawer(typeof(Vector3Reference))]
        public sealed class Vector3ReferenceDrawer : ReferenceDrawer { }
    }
}
