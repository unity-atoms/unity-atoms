#if UNITY_2019_1_OR_NEWER
using UnityEditor;

namespace UnityAtoms.Editor
{
    [CustomPropertyDrawer(typeof(FloatVariable))]
    public class FloatVariableDrawer : AtomDrawer<FloatVariable> { }
}
#endif
