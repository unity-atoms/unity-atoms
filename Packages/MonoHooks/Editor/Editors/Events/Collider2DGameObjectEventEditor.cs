#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;
using UnityAtoms.MonoHooks;

namespace UnityAtoms.MonoHooks.Editor
{
    /// <summary>
    /// Event property drawer of type `Collider2DGameObject`. Inherits from `AtomEventEditor&lt;Collider2DGameObject, Collider2DGameObjectEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(Collider2DGameObjectEvent))]
    public sealed class Collider2DGameObjectEventEditor : AtomEventEditor<Collider2DGameObject, Collider2DGameObjectEvent> { }
}
#endif
