#if UNITY_2019_1_OR_NEWER
using UnityEditor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// List property drawer of type `GameObject`. Inherits from `AtomDrawer&lt;GameObjectList&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(GameObjectList))]
    public class GameObjectListDrawer : AtomDrawer<GameObjectList> { }
}
#endif
