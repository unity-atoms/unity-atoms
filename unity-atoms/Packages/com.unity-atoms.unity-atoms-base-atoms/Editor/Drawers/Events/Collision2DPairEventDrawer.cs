#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `Collision2DPair`. Inherits from `AtomDrawer&lt;Collision2DPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(Collision2DPairEvent))]
    public class Collision2DPairEventDrawer : AtomDrawer<Collision2DPairEvent> { }
}
#endif
