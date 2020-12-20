#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `IntPair`. Inherits from `AtomEventEditor&lt;IntPair, IntPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(IntPairEvent))]
    public sealed class IntPairEventEditor : AtomEventEditor<IntPair, IntPairEvent> { }
}
#endif
