#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Variable property drawer of type `Vector3`. Inherits from `AtomDrawer&lt;Vector3Variable&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(Vector3Variable))]
    public class Vector3VariableDrawer : VariableDrawer<Vector3Variable> { }
}
#endif
