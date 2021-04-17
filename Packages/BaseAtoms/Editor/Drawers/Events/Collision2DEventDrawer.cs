#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `Collision2D`. Inherits from `AtomDrawer&lt;Collision2DEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(Collision2DEvent))]
    public class Collision2DEventDrawer : AtomDrawer<Collision2DEvent> { }
}
#endif
