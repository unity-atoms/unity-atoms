#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;
using UnityEngine;


namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `Color`. Inherits from `AtomEventInstancerEditor&lt;Color, ColorEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(ColorEventInstancer))]
    public sealed class ColorEventInstancerEditor : AtomEventInstancerEditor<Color, ColorEvent> { }
}
#endif
