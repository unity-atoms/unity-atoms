#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.MonoHooks.Editor
{
    /// <summary>
    /// Event property drawer of type `Collider2DGameObjectPair`. Inherits from `AtomDrawer&lt;Collider2DGameObjectPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(Collider2DGameObjectPairEvent))]
    public class Collider2DGameObjectPairEventDrawer : AtomDrawer<Collider2DGameObjectPairEvent> { }
}
#endif
