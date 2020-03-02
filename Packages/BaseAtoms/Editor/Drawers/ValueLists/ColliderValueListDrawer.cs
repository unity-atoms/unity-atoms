#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Value List property drawer of type `Collider`. Inherits from `AtomDrawer&lt;ColliderValueList&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(ColliderValueList))]
    public class ColliderValueListDrawer : AtomDrawer<ColliderValueList> { }
}
#endif
