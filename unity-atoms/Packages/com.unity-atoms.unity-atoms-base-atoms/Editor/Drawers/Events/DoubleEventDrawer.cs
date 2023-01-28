#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `double`. Inherits from `AtomDrawer&lt;DoubleEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(DoubleEvent))]
    public class DoubleEventDrawer : AtomDrawer<DoubleEvent> { }
}
#endif
