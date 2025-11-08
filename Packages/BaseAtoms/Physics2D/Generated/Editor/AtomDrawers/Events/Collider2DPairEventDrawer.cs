#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `Collider2DPair`. Inherits from `AtomDrawer&lt;Collider2DPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(Collider2DPairEvent))]
    public class Collider2DPairEventDrawer : AtomDrawer<Collider2DPairEvent> { }
}
#endif
