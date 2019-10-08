#if UNITY_2019_1_OR_NEWER
using UnityEditor;

namespace UnityAtoms.Editor
{
    [CustomPropertyDrawer(typeof(ColliderColliderEvent))]
    public class ColliderColliderEventDrawer : AtomDrawer<ColliderColliderEvent> { }
}
#endif
