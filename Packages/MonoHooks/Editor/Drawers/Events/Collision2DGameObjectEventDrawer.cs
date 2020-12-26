#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.MonoHooks.Editor
{
    /// <summary>
    /// Event property drawer of type `Collision2DGameObject`. Inherits from `AtomDrawer&lt;Collision2DGameObjectEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(Collision2DGameObjectEvent))]
    public class Collision2DGameObjectEventDrawer : AtomDrawer<Collision2DGameObjectEvent> { }
}
#endif
