using UnityEditor;

namespace UnityAtoms.FSM.Editor
{
    /// <summary>
    /// Custom property drawer for type `FiniteStateMachineInstancer`. 
    /// </summary>
    [CustomEditor(typeof(FiniteStateMachineInstancer))]
    public sealed class FiniteStateMachineInstancerEditor : UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            DrawPropertiesExcluding(serializedObject, new string[] { "_base" });
            serializedObject.ApplyModifiedProperties();
        }
    }
}
