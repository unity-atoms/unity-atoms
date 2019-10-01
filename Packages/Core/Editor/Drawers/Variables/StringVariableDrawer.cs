#if UNITY_2019_1_OR_NEWER
using UnityEditor;

namespace UnityAtoms.Editor
{
    [CustomPropertyDrawer(typeof(StringVariable))]
    public class StringVariableDrawer : AtomDrawer<StringVariable> { }
}
#endif
