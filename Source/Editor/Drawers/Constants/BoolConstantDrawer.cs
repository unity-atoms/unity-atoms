#if UNITY_2019_1_OR_NEWER
using UnityEditor;

namespace UnityAtoms.Editor
{
    [CustomPropertyDrawer(typeof(BoolConstant))]
    public class BoolConstantDrawer : AtomDrawer<BoolConstant> { }
}
#endif
