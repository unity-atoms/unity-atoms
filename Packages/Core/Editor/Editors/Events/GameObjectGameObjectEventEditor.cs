#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityEngine;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `&lt;GameObject, GameObject&gt;`. Inherits from `AtomEventEditor&lt;GameObject, GameObject, GameObjectEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(GameObjectGameObjectEvent))]
    public sealed class GameObjectGameObjectEventEditor : AtomEventEditor<GameObject, GameObject, GameObjectGameObjectEvent> { }
}
#endif
