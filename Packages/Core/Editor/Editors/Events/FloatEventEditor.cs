#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `float`. Inherits from `AtomEventEditor&lt;float, FloatEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(FloatEvent))]
    public sealed class FloatEventEditor : AtomEventEditor<float, FloatEvent> { }
}
#endif
