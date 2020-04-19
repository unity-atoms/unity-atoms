#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;
using UnityEngine;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `Vector3Pair`. Inherits from `AtomEventEditor&lt;Vector3Pair, Vector3PairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(Vector3PairEvent))]
    public sealed class Vector3PairEventEditor : AtomEventEditor<Vector3Pair, Vector3PairEvent> { }
}
#endif
