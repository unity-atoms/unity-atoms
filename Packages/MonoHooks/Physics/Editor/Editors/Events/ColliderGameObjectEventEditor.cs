#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;
using UnityAtoms.MonoHooks;

namespace UnityAtoms.MonoHooks.Editor
{
    /// <summary>
    /// Event property drawer of type `ColliderGameObject`. Inherits from `AtomEventEditor&lt;ColliderGameObject, ColliderGameObjectEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(ColliderGameObjectEvent))]
    public sealed class ColliderGameObjectEventEditor : AtomEventEditor<ColliderGameObject, ColliderGameObjectEvent> { }
}
#endif
