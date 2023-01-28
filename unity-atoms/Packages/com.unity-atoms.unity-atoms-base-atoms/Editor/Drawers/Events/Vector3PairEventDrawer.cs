#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `Vector3Pair`. Inherits from `AtomDrawer&lt;Vector3PairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(Vector3PairEvent))]
    public class Vector3PairEventDrawer : AtomDrawer<Vector3PairEvent> { }
}
#endif
