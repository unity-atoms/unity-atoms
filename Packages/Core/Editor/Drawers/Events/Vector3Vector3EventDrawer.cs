#if UNITY_2019_1_OR_NEWER
using UnityEditor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event x 2 property drawer of type `Vector3`. Inherits from `AtomDrawer&lt;Vector3Vector3Event&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(Vector3Vector3Event))]
    public class Vector3Vector3EventDrawer : AtomDrawer<Vector3Vector3Event> { }
}
#endif
