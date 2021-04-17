#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `QuaternionPair`. Inherits from `AtomDrawer&lt;QuaternionPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(QuaternionPairEvent))]
    public class QuaternionPairEventDrawer : AtomDrawer<QuaternionPairEvent> { }
}
#endif
