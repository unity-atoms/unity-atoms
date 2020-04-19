#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.MonoHooks.Editor
{
    /// <summary>
    /// Variable property drawer of type `Collider2DGameObject`. Inherits from `AtomDrawer&lt;Collider2DGameObjectVariable&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(Collider2DGameObjectVariable))]
    public class Collider2DGameObjectVariableDrawer : VariableDrawer<Collider2DGameObjectVariable> { }
}
#endif
