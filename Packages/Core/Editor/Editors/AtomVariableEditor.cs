using UnityEditor;
using UnityEngine;

namespace UnityAtoms.Editor{
    public abstract class AtomVariableEditor<T> : UnityEditor.Editor
    {
        protected virtual T FromProperty(SerializedProperty property) => property.GetValue<T>();
        protected abstract T Field(string label, T value);

        private bool _lockedInitialValue = true;
        public override void OnInspectorGUI()
        {
            EditorGUILayout.PropertyField(serializedObject.FindProperty("_developerDescription"));
            EditorGUILayout.Space();

            EditorGUILayout.BeginHorizontal();
            EditorGUI.BeginDisabledGroup(_lockedInitialValue && EditorApplication.isPlayingOrWillChangePlaymode);
            EditorGUILayout.PropertyField(serializedObject.FindProperty("_initialValue"));
            EditorGUI.EndDisabledGroup();
            if(EditorApplication.isPlaying)
            {
                _lockedInitialValue = GUILayout.Toggle(_lockedInitialValue, "", new GUIStyle("IN LockButton"){fixedHeight = 16, margin = new RectOffset(0, 2, 4, 0)});
            }
            EditorGUILayout.EndHorizontal();




            EditorGUI.BeginChangeCheck();
            EditorGUI.BeginDisabledGroup(!EditorApplication.isPlaying);
            T value = FromProperty(serializedObject.FindProperty("_value"));
            value = Field("Value", value);
            EditorGUI.EndDisabledGroup();
            if (EditorGUI.EndChangeCheck() && target is AtomBaseVariable atomTarget)
            {
                atomTarget.BaseValue = value;
            }

            EditorGUI.BeginDisabledGroup(true);
            EditorGUILayout.PropertyField(serializedObject.FindProperty("_oldValue"));
            EditorGUI.EndDisabledGroup();

            EditorGUILayout.PropertyField(serializedObject.FindProperty("Changed"));
            EditorGUILayout.PropertyField(serializedObject.FindProperty("ChangedWithHistory"));

            serializedObject.ApplyModifiedProperties();

        }
    }
}
