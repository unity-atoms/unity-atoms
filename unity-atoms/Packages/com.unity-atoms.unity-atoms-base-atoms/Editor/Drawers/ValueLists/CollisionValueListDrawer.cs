#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Value List property drawer of type `Collision`. Inherits from `AtomDrawer&lt;CollisionValueList&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(CollisionValueList))]
    public class CollisionValueListDrawer : AtomDrawer<CollisionValueList> { }
}
#endif
