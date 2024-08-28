#if UNITY_2019_1_OR_NEWER && PACKAGE_UNITY_PHYSICS2D
using UnityAtoms.Editor;
using UnityEditor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Value List property drawer of type `Collider2D`. Inherits from `AtomDrawer&lt;Collider2DValueList&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(Collider2DValueList))]
    public class Collider2DValueListDrawer : AtomDrawer<Collider2DValueList> { }
}
#endif
