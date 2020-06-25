#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.MonoHooks.Editor
{
    /// <summary>
    /// Constant property drawer of type `Collider2DGameObject`. Inherits from `AtomDrawer&lt;Collider2DGameObjectConstant&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(Collider2DGameObjectConstant))]
    public class Collider2DGameObjectConstantDrawer : VariableDrawer<Collider2DGameObjectConstant> { }
}
#endif
