#if UNITY_2019_1_OR_NEWER
using UnityEditor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event x 2 property drawer of type `float`. Inherits from `AtomDrawer&lt;FloatFloatEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(FloatFloatEvent))]
    public class FloatFloatEventDrawer : AtomDrawer<FloatFloatEvent> { }
}
#endif
