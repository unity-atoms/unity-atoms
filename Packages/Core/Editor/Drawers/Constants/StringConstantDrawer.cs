#if UNITY_2019_1_OR_NEWER
using UnityEditor;

namespace UnityAtoms.Editor
{
    [CustomPropertyDrawer(typeof(StringConstant))]
    public class StringConstantDrawer : AtomDrawer<StringConstant> { }
}
#endif
