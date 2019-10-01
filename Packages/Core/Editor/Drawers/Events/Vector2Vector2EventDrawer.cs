#if UNITY_2019_1_OR_NEWER
using UnityEditor;

namespace UnityAtoms.Editor
{
    [CustomPropertyDrawer(typeof(Vector2Vector2Event))]
    public class Vector2Vector2EventDrawer : AtomDrawer<Vector2Vector2Event> { }
}
#endif
