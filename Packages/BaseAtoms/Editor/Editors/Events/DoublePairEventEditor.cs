#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `DoublePair`. Inherits from `AtomEventEditor&lt;DoublePair, DoublePairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(DoublePairEvent))]
    public sealed class DoublePairEventEditor : AtomEventEditor<DoublePair, DoublePairEvent> { }
}
#endif
