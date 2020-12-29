#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;
using UnityEngine;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `CollisionPair`. Inherits from `AtomEventEditor&lt;CollisionPair, CollisionPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(CollisionPairEvent))]
    public sealed class CollisionPairEventEditor : AtomEventEditor<CollisionPair, CollisionPairEvent> { }
}
#endif
