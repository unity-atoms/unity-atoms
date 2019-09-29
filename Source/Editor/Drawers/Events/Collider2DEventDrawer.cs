#if UNITY_2019_1_OR_NEWER
using UnityEditor;

namespace UnityAtoms.Editor
{
    [CustomPropertyDrawer(typeof(Collider2DEvent))]
    public class Collider2DEventDrawer : AtomDrawer<Collider2DEvent> { }
}
#endif
