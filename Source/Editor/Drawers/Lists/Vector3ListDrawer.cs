#if UNITY_2019_1_OR_NEWER
using UnityEditor;

namespace UnityAtoms.Editor
{
    [CustomPropertyDrawer(typeof(Vector3List))]
    public class Vector3ListDrawer : AtomDrawer<Vector3List> { }
}
#endif
