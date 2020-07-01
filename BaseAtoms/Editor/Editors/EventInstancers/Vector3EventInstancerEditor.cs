#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;
using UnityEngine;


namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `Vector3`. Inherits from `AtomEventInstancerEditor&lt;Vector3, Vector3Event&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(Vector3EventInstancer))]
    public sealed class Vector3EventInstancerEditor : AtomEventInstancerEditor<Vector3, Vector3Event> { }
}
#endif
