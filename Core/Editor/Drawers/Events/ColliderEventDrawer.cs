#if UNITY_2019_1_OR_NEWER
using UnityEditor;

namespace UnityAtoms.Editor
{
    [CustomPropertyDrawer(typeof(ColliderEvent))]
    public class ColliderEventDrawer : AtomDrawer<ColliderEvent> { }
}
#endif
