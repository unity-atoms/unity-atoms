using UnityEditor;
using UnityEngine;

namespace UnityAtoms.Editor{
    [CustomEditor(typeof(ColorVariable))]
    public class ColorVariableEditor : AtomVariableEditor<Color>
    {
    }
}
