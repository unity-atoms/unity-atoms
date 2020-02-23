#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityEngine;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `&lt;Collider2D, Collider2D&gt;`. Inherits from `AtomEventEditor&lt;Collider2D, Collider2D, Collider2DEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(Collider2DCollider2DEvent))]
    public sealed class Collider2DCollider2DEventEditor : AtomEventEditor<Collider2D, Collider2D, Collider2DCollider2DEvent> { }
}
#endif
