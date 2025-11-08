#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;
using UnityAtoms.MonoHooks;

namespace UnityAtoms.MonoHooks.Editor
{
    /// <summary>
    /// Event property drawer of type `Collider2DGameObjectPair`. Inherits from `AtomEventEditor&lt;Collider2DGameObjectPair, Collider2DGameObjectPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(Collider2DGameObjectPairEvent))]
    public sealed class Collider2DGameObjectPairEventEditor : AtomEventEditor<Collider2DGameObjectPair, Collider2DGameObjectPairEvent> { }
}
#endif
