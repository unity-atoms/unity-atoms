#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityEngine;

namespace UnityAtoms.Editor
{
    [CustomEditor(typeof(ColorEvent))]
    public sealed class ColorEventEditor : AtomEventEditor<Color, ColorEvent>
    {
        protected override VisualElement GetRaiseValueInput()
        {
            var input = new Toggle() { label = "Raise value", name = "Raise value", viewDataKey = "Raise value" };
            input.RegisterCallback<ChangeEvent<Color>>((evt) => { _raiseValue = evt.newValue; });
            return input;
        }
    }
}
#endif
