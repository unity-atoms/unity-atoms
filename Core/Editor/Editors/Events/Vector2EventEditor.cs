#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityEngine;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `Vector2`. Inherits from `AtomEventEditor&lt;Vector2, Vector2Event&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(Vector2Event))]
    public sealed class Vector2EventEditor : AtomEventEditor<Vector2, Vector2Event>
    {
        protected override VisualElement GetRaiseValueInput()
        {
            var input = new Toggle() { label = "Raise value", name = "Raise value", viewDataKey = "Raise value" };
            input.RegisterCallback<ChangeEvent<Vector2>>((evt) => { _raiseValue = evt.newValue; });
            return input;
        }
    }
}
#endif
