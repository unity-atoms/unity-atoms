#if UNITY_2019_1_OR_NEWER
using UnityEditor;

namespace UnityAtoms.Editor
{
    [CustomPropertyDrawer(typeof(Vector3Variable))]
    public class Vector3VariableDrawer : AtomDrawer<Vector3Variable> { }
}
#endif
