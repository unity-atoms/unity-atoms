#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.MonoHooks.Editor
{
    /// <summary>
    /// Event property drawer of type `ColliderGameObjectPair`. Inherits from `AtomDrawer&lt;ColliderGameObjectPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(ColliderGameObjectPairEvent))]
    public class ColliderGameObjectPairEventDrawer : AtomDrawer<ColliderGameObjectPairEvent> { }
}
#endif
