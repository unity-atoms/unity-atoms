#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;
using UnityEngine;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `Vector2Pair`. Inherits from `AtomEventEditor&lt;Vector2Pair, Vector2PairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(Vector2PairEvent))]
    public sealed class Vector2PairEventEditor : AtomEventEditor<Vector2Pair, Vector2PairEvent> { }
}
#endif
