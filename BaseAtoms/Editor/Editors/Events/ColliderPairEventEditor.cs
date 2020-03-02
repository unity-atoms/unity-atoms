#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;
using UnityEngine;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `ColliderPair`. Inherits from `AtomEventEditor&lt;ColliderPair, ColliderPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(ColliderPairEvent))]
    public sealed class ColliderPairEventEditor : AtomEventEditor<ColliderPair, ColliderPairEvent> { }
}
#endif
