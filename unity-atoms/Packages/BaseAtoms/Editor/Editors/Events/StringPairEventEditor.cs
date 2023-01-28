#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `StringPair`. Inherits from `AtomEventEditor&lt;StringPair, StringPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(StringPairEvent))]
    public sealed class StringPairEventEditor : AtomEventEditor<StringPair, StringPairEvent> { }
}
#endif
