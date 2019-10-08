#if UNITY_2019_1_OR_NEWER
using UnityEditor;

namespace UnityAtoms.Editor
{
    [CustomPropertyDrawer(typeof(Collider2DList))]
    public class Collider2DListDrawer : AtomDrawer<Collider2DList> { }
}
#endif
