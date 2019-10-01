#if UNITY_2019_1_OR_NEWER
using UnityEditor;

namespace UnityAtoms.Editor
{
    [CustomPropertyDrawer(typeof(Collider2DCollider2DEvent))]
    public class Collider2DCollider2DEventDrawer : AtomDrawer<Collider2DCollider2DEvent> { }
}
#endif
