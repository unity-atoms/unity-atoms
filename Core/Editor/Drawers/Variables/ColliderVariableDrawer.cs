#if UNITY_2019_1_OR_NEWER
using UnityEditor;

namespace UnityAtoms.Editor
{
    [CustomPropertyDrawer(typeof(ColliderVariable))]
    public class ColliderVariableDrawer : AtomDrawer<ColliderVariable> { }
}
#endif
