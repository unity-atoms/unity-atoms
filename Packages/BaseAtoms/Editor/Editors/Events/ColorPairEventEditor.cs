#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;
using UnityEngine;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `ColorPair`. Inherits from `AtomEventEditor&lt;ColorPair, ColorPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(ColorPairEvent))]
    public sealed class ColorPairEventEditor : AtomEventEditor<ColorPair, ColorPairEvent> { }
}
#endif
