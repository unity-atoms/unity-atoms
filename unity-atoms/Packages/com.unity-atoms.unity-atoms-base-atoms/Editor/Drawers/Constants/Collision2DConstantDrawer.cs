#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Constant property drawer of type `Collision2D`. Inherits from `AtomDrawer&lt;Collision2DConstant&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(Collision2DConstant))]
    public class Collision2DConstantDrawer : VariableDrawer<Collision2DConstant> { }
}
#endif
