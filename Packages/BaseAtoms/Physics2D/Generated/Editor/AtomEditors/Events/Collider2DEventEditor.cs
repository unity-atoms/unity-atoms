#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;
using UnityEngine;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `UnityEngine.Collider2D`. Inherits from `AtomEventEditor&lt;UnityEngine.Collider2D, Collider2DEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(Collider2DEvent))]
    public sealed class Collider2DEventEditor : AtomEventEditor<UnityEngine.Collider2D, Collider2DEvent> { }
}
#endif
