#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Mobile.Editor
{
    [CustomPropertyDrawer(typeof(TouchUserInputEvent))]
    public class TouchUserInputEventDrawer : AtomDrawer<TouchUserInputEvent> { }
}
#endif
