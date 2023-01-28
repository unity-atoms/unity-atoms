#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.MonoHooks.Editor
{
    /// <summary>
    /// Value List property drawer of type `CollisionGameObject`. Inherits from `AtomDrawer&lt;CollisionGameObjectValueList&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(CollisionGameObjectValueList))]
    public class CollisionGameObjectValueListDrawer : AtomDrawer<CollisionGameObjectValueList> { }
}
#endif
