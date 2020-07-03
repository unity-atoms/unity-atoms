#if UNITY_2019_1_OR_NEWER
using UnityAtoms.Editor;
using UnityEditor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `Collision`. Inherits from `AtomDrawer&lt;CollisionEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer (typeof (CollisionEvent))]
    public class CollisionEventDrawer : AtomDrawer<CollisionEvent> { }
}
#endif