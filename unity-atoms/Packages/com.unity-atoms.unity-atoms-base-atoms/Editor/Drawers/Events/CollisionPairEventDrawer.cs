#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `CollisionPair`. Inherits from `AtomDrawer&lt;CollisionPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(CollisionPairEvent))]
    public class CollisionPairEventDrawer : AtomDrawer<CollisionPairEvent> { }
}
#endif
