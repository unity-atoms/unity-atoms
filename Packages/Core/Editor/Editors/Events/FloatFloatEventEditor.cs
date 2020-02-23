#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `&lt;float, float&gt;`. Inherits from `AtomEventEditor&lt;float, float, FloatEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(FloatFloatEvent))]
    public sealed class FloatFloatEventEditor : AtomEventEditor<float, float, FloatFloatEvent> { }
}
#endif
