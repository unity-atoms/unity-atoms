#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.MonoHooks.Editor
{
    /// <summary>
    /// Constant property drawer of type `Collision2DGameObject`. Inherits from `AtomDrawer&lt;Collision2DGameObjectConstant&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(Collision2DGameObjectConstant))]
    public class Collision2DGameObjectConstantDrawer : VariableDrawer<Collision2DGameObjectConstant> { }
}
#endif
