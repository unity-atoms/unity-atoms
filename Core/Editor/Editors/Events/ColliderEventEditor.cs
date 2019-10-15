#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityEngine;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `Collider`. Inherits from `AtomEventEditor&lt;Collider, ColliderEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(ColliderEvent))]
    public sealed class ColliderEventEditor : AtomEventEditor<Collider, ColliderEvent>
    {
        protected override VisualElement GetRaiseValueInput()
        {
            var input = new Toggle() { label = "Raise value", name = "Raise value", viewDataKey = "Raise value" };
            input.RegisterCallback<ChangeEvent<Collider>>((evt) => { _raiseValue = evt.newValue; });
            return input;
        }
    }
}
#endif
