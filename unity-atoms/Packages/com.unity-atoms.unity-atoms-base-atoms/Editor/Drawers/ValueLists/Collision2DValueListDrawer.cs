#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Value List property drawer of type `Collision2D`. Inherits from `AtomDrawer&lt;Collision2DValueList&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(Collision2DValueList))]
    public class Collision2DValueListDrawer : AtomDrawer<Collision2DValueList> { }
}
#endif
