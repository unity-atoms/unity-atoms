#if UNITY_2019_1_OR_NEWER
using UnityEditor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `Color`. Inherits from `AtomDrawer&lt;ColorEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(ColorEvent))]
    public class ColorEventDrawer : AtomDrawer<ColorEvent> { }
}
#endif
