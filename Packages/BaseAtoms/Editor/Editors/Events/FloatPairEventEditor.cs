#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `FloatPair`. Inherits from `AtomEventEditor&lt;FloatPair, FloatPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(FloatPairEvent))]
    public sealed class FloatPairEventEditor : AtomEventEditor<FloatPair, FloatPairEvent> { }
}
#endif
