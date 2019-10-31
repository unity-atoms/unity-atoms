using UnityEditor;

namespace UnityAtoms.Editor{
    public abstract class AtomVariableEditor<T> : UnityEditor.Editor
    {
        protected virtual T FromProperty(SerializedProperty property) => property.GetValue<T>();
        protected abstract T Field(string label, T value);

        public override void OnInspectorGUI()
        {
            EditorGUILayout.PropertyField(serializedObject.FindProperty("_developerDescription"));
            EditorGUILayout.Space();

            EditorGUI.BeginDisabledGroup(EditorApplication.isPlayingOrWillChangePlaymode);
            EditorGUILayout.PropertyField(serializedObject.FindProperty("_initialValue"));
            EditorGUI.EndDisabledGroup();

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
