#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;

namespace UnityAtoms.Mobile.Editor
{
    [CustomEditor(typeof(TouchUserInputEvent))]
    public sealed class TouchUserInputEventEditor : AtomEventEditor<TouchUserInput, TouchUserInputEvent>
    {
        protected override VisualElement GetRaiseValueInput()
        {
            var input = new Toggle() { label = "Raise value", name = "Raise value", viewDataKey = "Raise value" };
            input.RegisterCallback<ChangeEvent<TouchUserInput>>((evt) => { _raiseValue = evt.newValue; });
            return input;
        }
    }
}
#endif
