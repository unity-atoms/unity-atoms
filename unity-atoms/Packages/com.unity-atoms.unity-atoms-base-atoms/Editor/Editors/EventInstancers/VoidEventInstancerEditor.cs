#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;


namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `Void`. Inherits from `AtomEventInstancerEditor&lt;Void, VoidEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(VoidEventInstancer))]
    public sealed class VoidEventInstancerEditor : AtomEventInstancerEditor<Void, VoidEvent> { }
}
#endif
