#if UNITY_2019_1_OR_NEWER
using UnityEditor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Constant property drawer of type `Collider2D`. Inherits from `AtomDrawer&lt;Collider2DConstant&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(Collider2DConstant))]
    public class Collider2DConstantDrawer : VariableDrawer<Collider2DConstant> { }
}
#endif
