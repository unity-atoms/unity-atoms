#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `DoublePair`. Inherits from `AtomDrawer&lt;DoublePairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(DoublePairEvent))]
    public class DoublePairEventDrawer : AtomDrawer<DoublePairEvent> { }
}
#endif
