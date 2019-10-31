using UnityEditor;
using UnityEngine;

namespace UnityAtoms.Editor{
    [CustomEditor(typeof(Collider2DVariable))]
    public class Collider2DVariable : AtomVariableEditor<Collider2D>
    {
        protected override Collider2D Field(string label, Collider2D value) => SerializedPropertyExtensions.ValueLayoutField(label, value);
    }
}
