#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `GameObjectPair`. Inherits from `AtomDrawer&lt;GameObjectPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(GameObjectPairEvent))]
    public class GameObjectPairEventDrawer : AtomDrawer<GameObjectPairEvent> { }
}
#endif
