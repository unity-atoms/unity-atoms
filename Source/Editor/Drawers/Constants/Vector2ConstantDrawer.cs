#if UNITY_2019_1_OR_NEWER
using UnityEditor;

namespace UnityAtoms.Editor
{
    [CustomPropertyDrawer(typeof(Vector2Constant))]
    public class Vector2ConstantDrawer : AtomDrawer<Vector2Constant> { }
}
#endif
