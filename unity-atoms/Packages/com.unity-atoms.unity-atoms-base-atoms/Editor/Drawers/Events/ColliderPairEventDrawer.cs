#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `ColliderPair`. Inherits from `AtomDrawer&lt;ColliderPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(ColliderPairEvent))]
    public class ColliderPairEventDrawer : AtomDrawer<ColliderPairEvent> { }
}
#endif
