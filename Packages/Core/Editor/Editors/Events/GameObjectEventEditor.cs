#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityEngine;

namespace UnityAtoms.Editor
{
    [CustomEditor(typeof(GameObjectEvent))]
    public sealed class GameObjectEventEditor : AtomEventEditor<GameObject, GameObjectEvent>
    {
        protected override VisualElement GetRaiseValueInput()
        {
            var input = new Toggle() { label = "Raise value", name = "Raise value", viewDataKey = "Raise value" };
            input.RegisterCallback<ChangeEvent<GameObject>>((evt) => { _raiseValue = evt.newValue; });
            return input;
        }
    }
}
#endif
