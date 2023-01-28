#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `double`. Inherits from `AtomEventEditor&lt;double, DoubleEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(DoubleEvent))]
    public sealed class DoubleEventEditor : AtomEventEditor<double, DoubleEvent> { }
}
#endif
