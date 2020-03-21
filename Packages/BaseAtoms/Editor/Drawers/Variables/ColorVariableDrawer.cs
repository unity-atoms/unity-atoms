#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Variable property drawer of type `Color`. Inherits from `AtomDrawer&lt;ColorVariable&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(ColorVariable))]
    public class ColorVariableDrawer : VariableDrawer<ColorVariable> { }
}
#endif
