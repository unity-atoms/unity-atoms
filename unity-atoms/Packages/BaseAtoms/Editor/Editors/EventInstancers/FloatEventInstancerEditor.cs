#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;


namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `float`. Inherits from `AtomEventInstancerEditor&lt;float, FloatEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(FloatEventInstancer))]
    public sealed class FloatEventInstancerEditor : AtomEventInstancerEditor<float, FloatEvent> { }
}
#endif
