#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.MonoHooks.Editor
{
    /// <summary>
    /// Value List property drawer of type `Collision2DGameObject`. Inherits from `AtomDrawer&lt;Collision2DGameObjectValueList&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(Collision2DGameObjectValueList))]
    public class Collision2DGameObjectValueListDrawer : AtomDrawer<Collision2DGameObjectValueList> { }
}
#endif
