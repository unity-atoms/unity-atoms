#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.MonoHooks.Editor
{
    /// <summary>
    /// Value List property drawer of type `Collider2DGameObject`. Inherits from `AtomDrawer&lt;Collider2DGameObjectValueList&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(Collider2DGameObjectValueList))]
    public class Collider2DGameObjectValueListDrawer : AtomDrawer<Collider2DGameObjectValueList> { }
}
#endif
