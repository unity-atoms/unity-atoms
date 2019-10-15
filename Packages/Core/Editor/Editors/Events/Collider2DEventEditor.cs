#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityEngine;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `Collider2D`. Inherits from `AtomEventEditor&lt;Collider2D, Collider2DEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(Collider2DEvent))]
    public sealed class Collider2DEventEditor : AtomEventEditor<Collider2D, Collider2DEvent>
    {
        protected override VisualElement GetRaiseValueInput()
        {
            var input = new Toggle() { label = "Raise value", name = "Raise value", viewDataKey = "Raise value" };
            input.RegisterCallback<ChangeEvent<Collider2D>>((evt) => { _raiseValue = evt.newValue; });
            return input;
        }
    }
}
#endif
