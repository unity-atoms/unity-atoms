#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;


namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `int`. Inherits from `AtomEventInstancerEditor&lt;int, IntEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(IntEventInstancer))]
    public sealed class IntEventInstancerEditor : AtomEventInstancerEditor<int, IntEvent> { }
}
#endif
