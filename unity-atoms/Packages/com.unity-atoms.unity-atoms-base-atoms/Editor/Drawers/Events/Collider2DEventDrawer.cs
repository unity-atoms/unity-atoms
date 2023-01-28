#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `Collider2D`. Inherits from `AtomDrawer&lt;Collider2DEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(Collider2DEvent))]
    public class Collider2DEventDrawer : AtomDrawer<Collider2DEvent> { }
}
#endif
