#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityEngine;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `Color`. Inherits from `AtomEventEditor&lt;Color, ColorEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
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
