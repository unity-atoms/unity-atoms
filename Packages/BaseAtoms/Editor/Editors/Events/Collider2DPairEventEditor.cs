#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;
using UnityEngine;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `Collider2DPair`. Inherits from `AtomEventEditor&lt;Collider2DPair, Collider2DPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(Collider2DPairEvent))]
    public sealed class Collider2DPairEventEditor : AtomEventEditor<Collider2DPair, Collider2DPairEvent> { }
}
#endif
