#if UNITY_2019_1_OR_NEWER
using UnityEditor;

namespace UnityAtoms.Editor
{
    [CustomPropertyDrawer(typeof(Vector2Event))]
    public class Vector2EventDrawer : AtomDrawer<Vector2Event> { }
}
#endif
