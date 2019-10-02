#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityEngine;

namespace UnityAtoms.Editor
{
    [CustomEditor(typeof(Vector3Event))]
    public sealed class Vector3EventEditor : AtomEventEditor<Vector3, Vector3Event>
    {
        protected override VisualElement GetRaiseValueInput()
        {
            var input = new Toggle() { label = "Raise value", name = "Raise value", viewDataKey = "Raise value" };
            input.RegisterCallback<ChangeEvent<Vector3>>((evt) => { _raiseValue = evt.newValue; });
            return input;
        }
    }
}
#endif
