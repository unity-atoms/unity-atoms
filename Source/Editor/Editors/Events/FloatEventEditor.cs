#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEditor.UIElements;

namespace UnityAtoms.Editor
{
    [CustomEditor(typeof(FloatEvent))]
    public sealed class FloatEventEditor : AtomEventEditor<float, FloatEvent>
    {
        protected override VisualElement GetRaiseValueInput()
        {
            var input = new Toggle() { label = "Raise value", name = "Raise value", viewDataKey = "Raise value" };
            input.RegisterCallback<ChangeEvent<float>>((evt) => { _raiseValue = evt.newValue; });
            return input;
        }
    }
}
#endif
