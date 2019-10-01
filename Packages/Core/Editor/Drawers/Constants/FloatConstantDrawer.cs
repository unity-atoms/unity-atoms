#if UNITY_2019_1_OR_NEWER
using UnityEditor;

namespace UnityAtoms.Editor
{
    [CustomPropertyDrawer(typeof(FloatConstant))]
    public class FloatConstantDrawer : AtomDrawer<FloatConstant> { }
}
#endif
