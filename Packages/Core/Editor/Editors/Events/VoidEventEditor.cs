#if UNITY_2019_1_OR_NEWER
using UnityEngine;
using UnityEditor;
using UnityEngine.UIElements;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `Void`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(VoidEvent))]
    public sealed class VoidEventEditor : UnityEditor.Editor
    {
        public override VisualElement CreateInspectorGUI()
        {
            var root = new VisualElement();

            var desc = serializedObject.FindProperty("_developerDescription");
            var developerDescription = new TextField("Developer Description") { value = desc.stringValue, multiline = true };
            developerDescription.RegisterCallback<ChangeEvent<string>>(evt =>
            {
                desc.stringValue = evt.newValue;
                serializedObject.ApplyModifiedProperties();
            });
            root.Add(developerDescription);

            var runtimeWrapper = new VisualElement();
            runtimeWrapper.SetEnabled(Application.isPlaying);

            runtimeWrapper.Add(new Button(() =>
            {
                VoidEvent e = target as VoidEvent;
                e.Raise();
            })
            {
                text = "Raise"
            });
            root.Add(runtimeWrapper);

            return root;
        }
    }
}
#endif
