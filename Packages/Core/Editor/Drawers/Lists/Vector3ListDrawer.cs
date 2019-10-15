#if UNITY_2019_1_OR_NEWER
using UnityEditor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// List property drawer of type `Vector3`. Inherits from `AtomDrawer&lt;Vector3List&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(Vector3List))]
    public class Vector3ListDrawer : AtomDrawer<Vector3List> { }
}
#endif
