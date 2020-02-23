#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityEngine;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `Vector3`. Inherits from `AtomEventEditor&lt;Vector3, Vector3Event&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(Vector3Event))]
    public sealed class Vector3EventEditor : AtomEventEditor<Vector3, Vector3Event> { }
}
#endif
