#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `Quaternion`. Inherits from `AtomDrawer&lt;QuaternionEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(QuaternionEvent))]
    public class QuaternionEventDrawer : AtomDrawer<QuaternionEvent> { }
}
#endif
