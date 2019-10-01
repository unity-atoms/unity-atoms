#if UNITY_2019_1_OR_NEWER
using UnityEditor;

namespace UnityAtoms.Editor
{
    [CustomPropertyDrawer(typeof(Vector2Variable))]
    public class Vector2VariableDrawer : AtomDrawer<Vector2Variable> { }
}
#endif
