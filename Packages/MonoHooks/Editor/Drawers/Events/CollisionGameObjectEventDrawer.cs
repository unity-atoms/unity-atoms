#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.MonoHooks.Editor
{
    /// <summary>
    /// Event property drawer of type `CollisionGameObject`. Inherits from `AtomDrawer&lt;CollisionGameObjectEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(CollisionGameObjectEvent))]
    public class CollisionGameObjectEventDrawer : AtomDrawer<CollisionGameObjectEvent> { }
}
#endif
