#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;
using UnityEngine;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `Quaternion`. Inherits from `AtomEventEditor&lt;Quaternion, QuaternionEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(QuaternionEvent))]
    public sealed class QuaternionEventEditor : AtomEventEditor<Quaternion, QuaternionEvent> { }
}
#endif
