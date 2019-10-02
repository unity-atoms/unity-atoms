#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;

namespace UnityAtoms.Editor
{
    [CustomEditor(typeof(StringEvent))]
    public sealed class StringEventEditor : AtomEventEditor<string, StringEvent>
    {
        protected override VisualElement GetRaiseValueInput()
        {
            var input = new Toggle() { label = "Raise value", name = "Raise value", viewDataKey = "Raise value" };
            input.RegisterCallback<ChangeEvent<string>>((evt) => { _raiseValue = evt.newValue; });
            return input;
        }
    }
}
#endif
