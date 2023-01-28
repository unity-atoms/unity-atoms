#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Variable property drawer of type `float`. Inherits from `AtomDrawer&lt;FloatVariable&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(FloatVariable))]
    public class FloatVariableDrawer : VariableDrawer<FloatVariable> { }
}
#endif
