#if UNITY_2019_1_OR_NEWER
using UnityEditor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Constant property drawer of type `Vector2`. Inherits from `AtomDrawer&lt;Vector2Constant&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(Vector2Constant))]
    public class Vector2ConstantDrawer : AtomDrawer<Vector2Constant> { }
}
#endif
