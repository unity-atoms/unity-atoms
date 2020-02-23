#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityEngine;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `&lt;Color, Color&gt;`. Inherits from `AtomEventEditor&lt;Color, Color, ColorEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(ColorColorEvent))]
    public sealed class ColorColorEventEditor : AtomEventEditor<Color, Color, ColorColorEvent> { }
}
#endif
