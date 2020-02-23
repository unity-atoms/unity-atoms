#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityEngine;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `&lt;Vector2, Vector2&gt;`. Inherits from `AtomEventEditor&lt;Vector2, Vector2, Vector2Event&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(Vector2Vector2Event))]
    public sealed class Vector2Vector2EventEditor : AtomEventEditor<Vector2, Vector2, Vector2Vector2Event> { }
}
#endif
