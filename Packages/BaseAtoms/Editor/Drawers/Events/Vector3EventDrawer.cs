#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `Vector3`. Inherits from `AtomDrawer&lt;Vector3Event&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(Vector3Event))]
    public class Vector3EventDrawer : AtomDrawer<Vector3Event> { }
}
#endif
