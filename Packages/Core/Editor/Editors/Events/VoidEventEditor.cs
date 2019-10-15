#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `Void`. Inherits from `AtomEventEditor&lt;Void, VoidEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(VoidEvent))]
    public sealed class VoidEventEditor : AtomEventEditor<Void, VoidEvent>
    {
        protected override VisualElement GetRaiseValueInput()
        {
            var input = new Toggle() { label = "Raise value", name = "Raise value", viewDataKey = "Raise value" };
            input.RegisterCallback<ChangeEvent<Void>>((evt) => { _raiseValue = evt.newValue; });
            return input;
        }
    }
}
#endif
