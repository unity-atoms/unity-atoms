#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;

namespace UnityAtoms.Editor
{
    [CustomEditor(typeof(IntEvent))]
    public sealed class IntEventEditor : AtomEventEditor<int, IntEvent>
    {
        protected override VisualElement GetRaiseValueInput()
        {
            var input = new Toggle() { label = "Raise value", name = "Raise value", viewDataKey = "Raise value" };
            input.RegisterCallback<ChangeEvent<int>>((evt) => { _raiseValue = evt.newValue; });
            return input;
        }
    }
}
#endif
