#if UNITY_2019_1_OR_NEWER
using UnityEditor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Variable property drawer of type `Collider2D`. Inherits from `AtomDrawer&lt;Collider2DVariable&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(Collider2DVariable))]
    public class Collider2DVariableDrawer : AtomDrawer<Collider2DVariable> { }
}
#endif
