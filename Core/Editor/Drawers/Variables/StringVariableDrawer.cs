#if UNITY_2019_1_OR_NEWER
using UnityEditor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Variable property drawer of type `string`. Inherits from `AtomDrawer&lt;StringVariable&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(StringVariable))]
    public class StringVariableDrawer : AtomDrawer<StringVariable> { }
}
#endif
