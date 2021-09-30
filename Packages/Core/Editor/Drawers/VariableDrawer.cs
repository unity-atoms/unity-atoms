using UnityEditor;
using UnityEngine;

namespace UnityAtoms.Editor
{
    public abstract class VariableDrawer<T> : AtomDrawer<T> where T : ScriptableObject
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            if(property.serializedObject.isEditingMultipleObjects
             || property.objectReferenceValue == null)
            {
                base.OnGUI(position, property, label);
                return;
            }

            label = EditorGUI.BeginProperty(position, label, property);
            position = EditorGUI.PrefixLabel(position, label);

            var inner = new SerializedObject(property.objectReferenceValue);
            var valueProp = inner.FindProperty("_value");
            var isTypeSerializable = valueProp == null ? false : true;
            int indent = EditorGUI.indentLevel;

            Rect previewRect = new Rect(position);
            previewRect.width = isTypeSerializable ? GetPreviewSpace(valueProp.type) : GetPreviewSpace("");
            position.xMin = previewRect.xMax + 6f;

            EditorGUI.indentLevel = 0;

            // First draw the real property because of PrefixLabel inherits disable group when displaying value first.
            base.OnGUI(position, property, GUIContent.none);

            // Then draw value in disabled group.
            EditorGUI.BeginDisabledGroup(true);
            if(isTypeSerializable)
            {
                EditorGUI.PropertyField(previewRect, valueProp, GUIContent.none, false);
            }
            else
            {
                EditorGUI.LabelField(previewRect, "[Non serialized value]");
            }
            EditorGUI.EndDisabledGroup();

            EditorGUI.indentLevel = indent;
            EditorGUI.EndProperty();
        }

        private float GetPreviewSpace(string type)
        {
            switch(type)
            {
                case "Vector2":
                case "Vector3":
                    return 128;
                default:
                    return 58;
            }
        }
    }
}
