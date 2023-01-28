#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.MonoHooks.Editor
{
    /// <summary>
    /// Event property drawer of type `CollisionGameObjectPair`. Inherits from `AtomDrawer&lt;CollisionGameObjectPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(CollisionGameObjectPairEvent))]
    public class CollisionGameObjectPairEventDrawer : AtomDrawer<CollisionGameObjectPairEvent> { }
}
#endif
