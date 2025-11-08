#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;
using UnityEngine;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `UnityEngine.Collider`. Inherits from `AtomEventEditor&lt;UnityEngine.Collider, ColliderEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(ColliderEvent))]
    public sealed class ColliderEventEditor : AtomEventEditor<UnityEngine.Collider, ColliderEvent> { }
}
#endif
