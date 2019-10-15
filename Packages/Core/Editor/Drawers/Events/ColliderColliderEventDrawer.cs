#if UNITY_2019_1_OR_NEWER
using UnityEditor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event x 2 property drawer of type `Collider`. Inherits from `AtomDrawer&lt;ColliderColliderEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(ColliderColliderEvent))]
    public class ColliderColliderEventDrawer : AtomDrawer<ColliderColliderEvent> { }
}
#endif
