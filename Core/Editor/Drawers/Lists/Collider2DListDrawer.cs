#if UNITY_2019_1_OR_NEWER
using UnityEditor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// List property drawer of type `Collider2D`. Inherits from `AtomDrawer&lt;Collider2DList&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(Collider2DList))]
    public class Collider2DListDrawer : AtomDrawer<Collider2DList> { }
}
#endif
