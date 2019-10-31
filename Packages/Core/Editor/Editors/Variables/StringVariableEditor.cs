using UnityEditor;

namespace UnityAtoms.Editor
{
    [CustomEditor(typeof(StringVariable))]
    public class StringVariableEditor : AtomVariableEditor<string>
    {
        protected override string Field(string label, string value) => SerializedPropertyExtensions.ValueLayoutField(label, value);
    }
}
