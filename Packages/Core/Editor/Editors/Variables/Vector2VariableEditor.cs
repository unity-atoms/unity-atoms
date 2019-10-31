using UnityEditor;
using UnityEngine;

namespace UnityAtoms.Editor{
    [CustomEditor(typeof(Vector2Variable))]
    public class Vector2VariableEditor : AtomVariableEditor<Vector2>
    {
        protected override Vector2 Field(string label, Vector2 value) => SerializedPropertyExtensions.ValueLayoutField(label, value);
    }
}
