#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;
using UnityEngine;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `Collision`. Inherits from `AtomEventEditor&lt;Collision, CollisionEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(CollisionEvent))]
    public sealed class CollisionEventEditor : AtomEventEditor<Collision, CollisionEvent> { }
}
#endif
