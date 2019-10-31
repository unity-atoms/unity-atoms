using UnityEditor;

namespace UnityAtoms.Editor
{
    [CustomEditor(typeof(IntVariable))]
    public class IntVariableEditor : AtomVariableEditor<int>
    {
        protected override int Field(string label, int value) => SerializedPropertyExtensions.ValueLayoutField(label, value);
    }
}
