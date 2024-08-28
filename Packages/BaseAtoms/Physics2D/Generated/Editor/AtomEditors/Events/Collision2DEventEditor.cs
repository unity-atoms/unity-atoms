#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;
using UnityEngine;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `UnityEngine.Collision2D`. Inherits from `AtomEventEditor&lt;UnityEngine.Collision2D, Collision2DEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(Collision2DEvent))]
    public sealed class Collision2DEventEditor : AtomEventEditor<UnityEngine.Collision2D, Collision2DEvent> { }
}
#endif
