#if UNITY_2019_1_OR_NEWER
using UnityEditor;

namespace UnityAtoms.Editor
{
    [CustomPropertyDrawer(typeof(Collider2DVariable))]
    public class Collider2DVariableDrawer : AtomDrawer<Collider2DVariable> { }
}
#endif
