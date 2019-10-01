#if UNITY_2019_1_OR_NEWER
using UnityEditor;

namespace UnityAtoms.Editor
{
    [CustomPropertyDrawer(typeof(Vector3Constant))]
    public class Vector3ConstantDrawer : AtomDrawer<Vector3Constant> { }
}
#endif
