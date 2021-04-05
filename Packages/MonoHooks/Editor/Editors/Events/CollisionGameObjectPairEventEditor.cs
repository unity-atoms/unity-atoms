using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.MonoHooks.Editor
{
    /// <summary>
    /// Event property drawer of type `CollisionGameObjectPair`. Inherits from `AtomEventEditor&lt;CollisionGameObjectPair, CollisionGameObjectPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(CollisionGameObjectPairEvent))]
    public sealed class CollisionGameObjectPairEventEditor : AtomEventEditor<Pair<CollisionGameObject>> { }
}
