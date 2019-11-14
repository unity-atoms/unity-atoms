using UnityEditor;
using UnityEngine;

namespace UnityAtoms.Editor
{
    public abstract class VariableDrawer<T> : AtomDrawer<T> where T : ScriptableObject
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            if (property.serializedObject.isEditingMultipleObjects
             || property.objectReferenceValue == null)
            {
                base.OnGUI(position, property, label);
                return;
            }

            var inner = new SerializedObject(property.objectReferenceValue);
            var valueProp = inner.FindProperty("_value");
            var width = GetPreviewSpace(valueProp.type) + (property.depth == 0 ? EditorGUIUtility.labelWidth : 0);
            var restRect = IMGUIUtils.SnipRectH(position, width, out position, 6f);
            base.OnGUI(position, property, GUIContent.none);

            EditorGUI.BeginDisabledGroup(true);
            EditorGUI.PropertyField(restRect, valueProp, label, false);
            EditorGUI.EndDisabledGroup();
        }

        private float GetPreviewSpace(string type)
        {
            switch (type)
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
