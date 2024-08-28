#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;
using UnityAtoms.MonoHooks;

namespace UnityAtoms.MonoHooks.Editor
{
    /// <summary>
    /// Event property drawer of type `Collision2DGameObject`. Inherits from `AtomEventEditor&lt;Collision2DGameObject, Collision2DGameObjectEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(Collision2DGameObjectEvent))]
    public sealed class Collision2DGameObjectEventEditor : AtomEventEditor<Collision2DGameObject, Collision2DGameObjectEvent> { }
}
#endif
