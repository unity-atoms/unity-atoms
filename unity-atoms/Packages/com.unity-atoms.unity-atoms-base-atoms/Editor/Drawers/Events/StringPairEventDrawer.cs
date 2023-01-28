#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `StringPair`. Inherits from `AtomDrawer&lt;StringPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(StringPairEvent))]
    public class StringPairEventDrawer : AtomDrawer<StringPairEvent> { }
}
#endif
