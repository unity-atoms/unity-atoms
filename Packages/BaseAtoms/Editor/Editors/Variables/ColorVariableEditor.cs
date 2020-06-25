using UnityEditor;
using UnityAtoms.Editor;
using UnityEngine;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Variable Inspector of type `Color`. Inherits from `AtomVariableEditor`
    /// </summary>
    [CustomEditor(typeof(ColorVariable))]
    public sealed class ColorVariableEditor : AtomVariableEditor<Color, ColorPair> { }
}
