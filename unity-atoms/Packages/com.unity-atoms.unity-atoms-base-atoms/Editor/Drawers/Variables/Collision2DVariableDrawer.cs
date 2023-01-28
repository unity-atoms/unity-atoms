#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Variable property drawer of type `Collision2D`. Inherits from `AtomDrawer&lt;Collision2DVariable&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(Collision2DVariable))]
    public class Collision2DVariableDrawer : VariableDrawer<Collision2DVariable> { }
}
#endif
