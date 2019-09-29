#if UNITY_2019_1_OR_NEWER
using UnityEditor;

namespace UnityAtoms.Editor
{
    [CustomPropertyDrawer(typeof(FloatList))]
    public class FloatListDrawer : AtomDrawer<FloatList> { }
}
#endif
