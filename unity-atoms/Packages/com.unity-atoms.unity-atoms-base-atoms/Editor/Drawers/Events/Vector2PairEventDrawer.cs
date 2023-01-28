#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `Vector2Pair`. Inherits from `AtomDrawer&lt;Vector2PairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(Vector2PairEvent))]
    public class Vector2PairEventDrawer : AtomDrawer<Vector2PairEvent> { }
}
#endif
