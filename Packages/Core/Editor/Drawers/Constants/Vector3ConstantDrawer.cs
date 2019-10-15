#if UNITY_2019_1_OR_NEWER
using UnityEditor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Constant property drawer of type `Vector3`. Inherits from `AtomDrawer&lt;Vector3Constant&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(Vector3Constant))]
    public class Vector3ConstantDrawer : AtomDrawer<Vector3Constant> { }
}
#endif
