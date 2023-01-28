#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Value List property drawer of type `GameObject`. Inherits from `AtomDrawer&lt;GameObjectValueList&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(GameObjectValueList))]
    public class GameObjectValueListDrawer : AtomDrawer<GameObjectValueList> { }
}
#endif
