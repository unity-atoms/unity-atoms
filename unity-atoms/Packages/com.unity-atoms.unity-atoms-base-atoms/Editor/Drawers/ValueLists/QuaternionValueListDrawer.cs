#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Value List property drawer of type `Quaternion`. Inherits from `AtomDrawer&lt;QuaternionValueList&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(QuaternionValueList))]
    public class QuaternionValueListDrawer : AtomDrawer<QuaternionValueList> { }
}
#endif
