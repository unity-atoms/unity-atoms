#if UNITY_2019_1_OR_NEWER
using UnityEditor;

namespace UnityAtoms.Editor
{
    [CustomPropertyDrawer(typeof(Vector3Event))]
    public class Vector3EventDrawer : AtomDrawer<Vector3Event> { }
}
#endif
