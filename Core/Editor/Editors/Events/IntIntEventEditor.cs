#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `&lt;int, int&gt;`. Inherits from `AtomEventEditor&lt;int, int, IntEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(IntIntEvent))]
    public sealed class IntIntEventEditor : AtomEventEditor<int, int, IntIntEvent> { }
}
#endif
