#if UNITY_2019_1_OR_NEWER
using UnityEditor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Variable property drawer of type `int`. Inherits from `AtomDrawer&lt;IntVariable&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(IntVariable))]
    public class IntVariableDrawer : AtomDrawer<IntVariable> { }
}
#endif
