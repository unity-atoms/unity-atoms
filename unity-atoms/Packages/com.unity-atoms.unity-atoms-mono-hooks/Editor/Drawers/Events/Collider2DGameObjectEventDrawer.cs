#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.MonoHooks.Editor
{
    /// <summary>
    /// Event property drawer of type `Collider2DGameObject`. Inherits from `AtomDrawer&lt;Collider2DGameObjectEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(Collider2DGameObjectEvent))]
    public class Collider2DGameObjectEventDrawer : AtomDrawer<Collider2DGameObjectEvent> { }
}
#endif
