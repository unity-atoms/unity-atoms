#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Variable property drawer of type `Quaternion`. Inherits from `AtomDrawer&lt;QuaternionVariable&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(QuaternionVariable))]
    public class QuaternionVariableDrawer : VariableDrawer<QuaternionVariable> { }
}
#endif
