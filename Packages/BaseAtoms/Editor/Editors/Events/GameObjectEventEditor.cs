#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;
using UnityEngine;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `GameObject`. Inherits from `AtomEventEditor&lt;GameObject, GameObjectEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(GameObjectEvent))]
    public sealed class GameObjectEventEditor : AtomEventEditor<GameObject, GameObjectEvent> { }
}
#endif
