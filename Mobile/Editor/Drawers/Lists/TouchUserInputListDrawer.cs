#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Mobile.Editor
{
    /// <summary>
    /// List property drawer of type `TouchUserInput`. Inherits from `AtomDrawer&lt;TouchUserInputList&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(TouchUserInputList))]
    public class TouchUserInputListDrawer : AtomDrawer<TouchUserInputList> { }
}
#endif
