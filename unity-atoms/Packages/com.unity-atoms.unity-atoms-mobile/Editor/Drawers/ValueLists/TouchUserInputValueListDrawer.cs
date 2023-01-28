#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Mobile.Editor
{
    /// <summary>
    /// Value List property drawer of type `TouchUserInput`. Inherits from `AtomDrawer&lt;TouchUserInputValueList&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(TouchUserInputValueList))]
    public class TouchUserInputValueListDrawer : AtomDrawer<TouchUserInputValueList> { }
}
#endif
