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

            var widht = 58 + (property.depth == 0 ? EditorGUIUtility.labelWidth : 0);
            var restRect = IMGUIUtils.SnipRectH(position, widht, out position, 6f);
            base.OnGUI(position, property, GUIContent.none);

            EditorGUI.BeginDisabledGroup(true);

            var inner = new SerializedObject(property.objectReferenceValue);
            EditorGUI.PropertyField(restRect, inner.FindProperty("_value"), label, false);
            EditorGUI.EndDisabledGroup();
        }
    }
}
