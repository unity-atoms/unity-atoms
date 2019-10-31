using UnityEditor;

namespace UnityAtoms.Editor{
    [CustomEditor(typeof(FloatVariable))]
    public class FloatVariableEditor : AtomVariableEditor<float>
    {
        protected override float Field(string label, float value) => SerializedPropertyExtensions.ValueLayoutField(label, value);
    }
}
