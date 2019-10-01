#if UNITY_2019_1_OR_NEWER
using UnityEditor;

namespace UnityAtoms.Editor
{
    [CustomPropertyDrawer(typeof(IntConstant))]
    public class IntConstantDrawer : AtomDrawer<IntConstant> { }
}
#endif
