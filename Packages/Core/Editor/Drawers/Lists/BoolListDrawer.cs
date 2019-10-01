#if UNITY_2019_1_OR_NEWER
using UnityEditor;

namespace UnityAtoms.Editor
{
    [CustomPropertyDrawer(typeof(BoolList))]
    public class BoolListDrawer : AtomDrawer<BoolList> { }
}
#endif
