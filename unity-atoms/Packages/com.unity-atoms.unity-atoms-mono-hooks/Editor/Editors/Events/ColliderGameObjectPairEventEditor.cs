#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;
using UnityAtoms.MonoHooks;

namespace UnityAtoms.MonoHooks.Editor
{
    /// <summary>
    /// Event property drawer of type `ColliderGameObjectPair`. Inherits from `AtomEventEditor&lt;ColliderGameObjectPair, ColliderGameObjectPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(ColliderGameObjectPairEvent))]
    public sealed class ColliderGameObjectPairEventEditor : AtomEventEditor<ColliderGameObjectPair, ColliderGameObjectPairEvent> { }
}
#endif
