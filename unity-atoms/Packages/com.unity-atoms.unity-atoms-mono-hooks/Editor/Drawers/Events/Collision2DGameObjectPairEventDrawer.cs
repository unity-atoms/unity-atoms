#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.MonoHooks.Editor
{
    /// <summary>
    /// Event property drawer of type `Collision2DGameObjectPair`. Inherits from `AtomDrawer&lt;Collision2DGameObjectPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(Collision2DGameObjectPairEvent))]
    public class Collision2DGameObjectPairEventDrawer : AtomDrawer<Collision2DGameObjectPairEvent> { }
}
#endif
