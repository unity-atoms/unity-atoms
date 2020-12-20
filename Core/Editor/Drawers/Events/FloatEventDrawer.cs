#if UNITY_2019_1_OR_NEWER
using UnityEditor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `float`. Inherits from `AtomDrawer&lt;FloatEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(FloatEvent))]
    public class FloatEventDrawer : AtomDrawer<FloatEvent> { }
}
#endif
