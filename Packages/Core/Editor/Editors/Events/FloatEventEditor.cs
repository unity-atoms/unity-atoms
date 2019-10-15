#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `float`. Inherits from `AtomEventEditor&lt;float, FloatEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
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
