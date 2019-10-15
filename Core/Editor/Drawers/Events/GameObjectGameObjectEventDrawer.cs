#if UNITY_2019_1_OR_NEWER
using UnityEditor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event x 2 property drawer of type `GameObject`. Inherits from `AtomDrawer&lt;GameObjectGameObjectEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(GameObjectGameObjectEvent))]
    public class GameObjectGameObjectEventDrawer : AtomDrawer<GameObjectGameObjectEvent> { }
}
#endif
