#if UNITY_2019_1_OR_NEWER
using UnityEditor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// List property drawer of type `Collider`. Inherits from `AtomDrawer&lt;ColliderList&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(ColliderList))]
    public class ColliderListDrawer : AtomDrawer<ColliderList> { }
}
#endif
