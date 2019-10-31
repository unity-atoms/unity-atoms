using UnityEditor;
using UnityEngine;

namespace UnityAtoms.Editor{
    [CustomEditor(typeof(ColliderVariable))]
    public class ColliderEditor : AtomVariableEditor<Collider>
    {
        protected override Collider Field(string label, Collider value) => SerializedPropertyExtensions.ValueLayoutField(label, value);
    }
}
