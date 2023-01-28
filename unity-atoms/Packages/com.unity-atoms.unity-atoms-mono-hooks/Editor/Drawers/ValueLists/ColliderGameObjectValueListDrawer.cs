#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.MonoHooks.Editor
{
    /// <summary>
    /// Value List property drawer of type `ColliderGameObject`. Inherits from `AtomDrawer&lt;ColliderGameObjectValueList&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(ColliderGameObjectValueList))]
    public class ColliderGameObjectValueListDrawer : AtomDrawer<ColliderGameObjectValueList> { }
}
#endif
