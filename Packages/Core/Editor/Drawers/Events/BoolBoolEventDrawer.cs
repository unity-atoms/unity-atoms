#if UNITY_2019_1_OR_NEWER
using UnityEditor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event x 2 property drawer of type `bool`. Inherits from `AtomDrawer&lt;BoolBoolEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(BoolBoolEvent))]
    public class BoolBoolEventDrawer : AtomDrawer<BoolBoolEvent> { }
}
#endif
