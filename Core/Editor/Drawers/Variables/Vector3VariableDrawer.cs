#if UNITY_2019_1_OR_NEWER
using UnityEditor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Variable property drawer of type `Vector3`. Inherits from `AtomDrawer&lt;Vector3Variable&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(Vector3Variable))]
    public class Vector3VariableDrawer : AtomDrawer<Vector3Variable> { }
}
#endif
