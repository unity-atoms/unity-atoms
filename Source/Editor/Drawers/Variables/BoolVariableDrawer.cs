#if UNITY_2019_1_OR_NEWER
using UnityEditor;

namespace UnityAtoms.Editor
{
    [CustomPropertyDrawer(typeof(BoolVariable))]
    public class BoolVariableDrawer : AtomDrawer<BoolVariable> { }
}
#endif
