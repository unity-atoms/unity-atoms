#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.MonoHooks.Editor
{
    /// <summary>
    /// Event property drawer of type `ColliderGameObject`. Inherits from `AtomDrawer&lt;ColliderGameObjectEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(ColliderGameObjectEvent))]
    public class ColliderGameObjectEventDrawer : AtomDrawer<ColliderGameObjectEvent> { }
}
#endif
