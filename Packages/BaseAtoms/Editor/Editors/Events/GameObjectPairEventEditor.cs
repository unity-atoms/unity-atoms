#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;
using UnityEngine;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `GameObjectPair`. Inherits from `AtomEventEditor&lt;GameObjectPair, GameObjectPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(GameObjectPairEvent))]
    public sealed class GameObjectPairEventEditor : AtomEventEditor<GameObjectPair, GameObjectPairEvent> { }
}
#endif
