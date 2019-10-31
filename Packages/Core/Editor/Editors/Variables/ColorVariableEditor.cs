using UnityEditor;
using UnityEngine;

namespace UnityAtoms.Editor{
    [CustomEditor(typeof(ColorVariable))]
    public class ColorVariableEditor : AtomVariableEditor<Color>
    {
        protected override Color Field(string label, Color value) => SerializedPropertyExtensions.ValueLayoutField(label, value);
    }
}
