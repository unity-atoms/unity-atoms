using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.MonoHooks.Editor
{
    /// <summary>
    /// Event property drawer of type `CollisionGameObject`. Inherits from `AtomEventEditor&lt;CollisionGameObject, CollisionGameObjectEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(CollisionGameObjectEvent))]
    public sealed class CollisionGameObjectEventEditor : AtomEventEditor<CollisionGameObject> { }
}
