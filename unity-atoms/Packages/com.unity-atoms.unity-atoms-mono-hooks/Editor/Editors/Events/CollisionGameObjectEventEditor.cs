#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;
using UnityAtoms.MonoHooks;

namespace UnityAtoms.MonoHooks.Editor
{
    /// <summary>
    /// Event property drawer of type `CollisionGameObject`. Inherits from `AtomEventEditor&lt;CollisionGameObject, CollisionGameObjectEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(CollisionGameObjectEvent))]
    public sealed class CollisionGameObjectEventEditor : AtomEventEditor<CollisionGameObject, CollisionGameObjectEvent> { }
}
#endif
