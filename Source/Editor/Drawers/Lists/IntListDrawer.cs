#if UNITY_2019_1_OR_NEWER
using UnityEditor;

namespace UnityAtoms.Editor
{
    [CustomPropertyDrawer(typeof(IntList))]
    public class IntListDrawer : AtomDrawer<IntList> { }
}
#endif
