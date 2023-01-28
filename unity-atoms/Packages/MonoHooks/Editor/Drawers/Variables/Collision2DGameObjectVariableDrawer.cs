#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.MonoHooks.Editor
{
    /// <summary>
    /// Variable property drawer of type `Collision2DGameObject`. Inherits from `AtomDrawer&lt;Collision2DGameObjectVariable&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(Collision2DGameObjectVariable))]
    public class Collision2DGameObjectVariableDrawer : VariableDrawer<Collision2DGameObjectVariable> { }
}
#endif
