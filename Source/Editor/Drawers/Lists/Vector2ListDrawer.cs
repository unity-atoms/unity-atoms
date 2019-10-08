#if UNITY_2019_1_OR_NEWER
using UnityEditor;

namespace UnityAtoms.Editor
{
    [CustomPropertyDrawer(typeof(Vector2List))]
    public class Vector2ListDrawer : AtomDrawer<Vector2List> { }
}
#endif
