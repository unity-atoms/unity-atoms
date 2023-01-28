#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;
using UnityAtoms.MonoHooks;

namespace UnityAtoms.MonoHooks.Editor
{
    /// <summary>
    /// Event property drawer of type `CollisionGameObjectPair`. Inherits from `AtomEventEditor&lt;CollisionGameObjectPair, CollisionGameObjectPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(CollisionGameObjectPairEvent))]
    public sealed class CollisionGameObjectPairEventEditor : AtomEventEditor<CollisionGameObjectPair, CollisionGameObjectPairEvent> { }
}
#endif
