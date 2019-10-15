#if UNITY_2019_1_OR_NEWER
using UnityEditor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `int`. Inherits from `AtomDrawer&lt;IntEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(IntEvent))]
    public class IntEventDrawer : AtomDrawer<IntEvent> { }
}
#endif
