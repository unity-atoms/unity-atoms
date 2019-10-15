#if UNITY_2019_1_OR_NEWER
using UnityEditor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `GameObject`. Inherits from `AtomDrawer&lt;GameObjectEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(GameObjectEvent))]
    public class GameObjectEventDrawer : AtomDrawer<GameObjectEvent> { }
}
#endif
