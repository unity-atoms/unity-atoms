#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.SceneMgmt;
using UnityAtoms.Editor;

namespace UnityAtoms.SceneMgmt.Editor
{
    /// <summary>
    /// Event property drawer of type `SceneField`. Inherits from `AtomEventEditor&lt;SceneField, SceneFieldEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(SceneFieldEvent))]
    public sealed class SceneFieldEventEditor : AtomEventEditor<SceneField, SceneFieldEvent>
    {
        protected override VisualElement GetRaiseValueInput()
        {
            var input = new Toggle() { label = "Raise value", name = "Raise value", viewDataKey = "Raise value" };
            input.RegisterCallback<ChangeEvent<SceneField>>((evt) => { _raiseValue = evt.newValue; });
            return input;
        }
    }
}
#endif
