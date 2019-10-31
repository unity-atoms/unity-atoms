using UnityEditor;
using UnityEngine;

namespace UnityAtoms.Editor{
    [CustomEditor(typeof(Vector3Variable))]
    public class Vector3VariableEditor : AtomVariableEditor<Vector3>
    {
        protected override Vector3 Field(string label, Vector3 value) => SerializedPropertyExtensions.ValueLayoutField(label, value);
    }
}
