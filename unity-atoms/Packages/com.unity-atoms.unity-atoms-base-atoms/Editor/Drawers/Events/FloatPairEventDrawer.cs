#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `FloatPair`. Inherits from `AtomDrawer&lt;FloatPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(FloatPairEvent))]
    public class FloatPairEventDrawer : AtomDrawer<FloatPairEvent> { }
}
#endif
