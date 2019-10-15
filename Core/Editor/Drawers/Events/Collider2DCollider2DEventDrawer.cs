#if UNITY_2019_1_OR_NEWER
using UnityEditor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event x 2 property drawer of type `Collider2D`. Inherits from `AtomDrawer&lt;Collider2DCollider2DEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(Collider2DCollider2DEvent))]
    public class Collider2DCollider2DEventDrawer : AtomDrawer<Collider2DCollider2DEvent> { }
}
#endif
