#if UNITY_2019_1_OR_NEWER
using UnityEditor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event x 2 property drawer of type `int`. Inherits from `AtomDrawer&lt;IntIntEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(IntIntEvent))]
    public class IntIntEventDrawer : AtomDrawer<IntIntEvent> { }
}
#endif
