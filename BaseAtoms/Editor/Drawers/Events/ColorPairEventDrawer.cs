#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `ColorPair`. Inherits from `AtomDrawer&lt;ColorPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(ColorPairEvent))]
    public class ColorPairEventDrawer : AtomDrawer<ColorPairEvent> { }
}
#endif
