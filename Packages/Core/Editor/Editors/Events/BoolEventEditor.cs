#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `bool`. Inherits from `AtomEventEditor&lt;bool, BoolEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(BoolEvent))]
    public sealed class BoolEventEditor : AtomEventEditor<bool, BoolEvent>
    {
        protected override VisualElement GetRaiseValueInput()
        {
            var input = new Toggle() { label = "Raise value", name = "Raise value", viewDataKey = "Raise value" };
            input.RegisterCallback<ChangeEvent<bool>>((evt) => { _raiseValue = evt.newValue; });
            return input;
        }
    }
}
#endif
