#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;
using UnityEngine;


namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `Vector2`. Inherits from `AtomEventInstancerEditor&lt;Vector2, Vector2Event&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(Vector2EventInstancer))]
    public sealed class Vector2EventInstancerEditor : AtomEventInstancerEditor<Vector2, Vector2Event> { }
}
#endif
