#if UNITY_2019_1_OR_NEWER
using UnityEditor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event x 2 property drawer of type `Color`. Inherits from `AtomDrawer&lt;ColorColorEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(ColorColorEvent))]
    public class ColorColorEventDrawer : AtomDrawer<ColorColorEvent> { }
}
#endif
