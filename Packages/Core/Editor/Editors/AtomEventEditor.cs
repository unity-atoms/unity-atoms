#if UNITY_2018_4_OR_NEWER
using UnityEngine;
#if UNITY_2018_4_OR_NEWER
using UnityEngine.Experimental.UIElements;
#elif UNITY_2019_1_OR_NEWER
using UnityEngine.UIElements;
#endif

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Custom editor for Events. Adds the possiblity to raise an Event from Unity's Inspector.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="E"></typeparam>
    public abstract class AtomEventEditor<T, E> : UnityEditor.Editor
        where E : AtomEvent<T>
    {
#if UNITY_2018_4_OR_NEWER

#elif UNITY_2019_1_OR_NEWER
        protected T _raiseValue = default(T);

        protected virtual VisualElement GetRaiseValueInput() { return null; }

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

            var input = GetRaiseValueInput();
            if (input != null)
            {
                runtimeWrapper.Add(input);
            }

            runtimeWrapper.Add(new Button(() =>
            {
                E e = target as E;
                e.Raise(_raiseValue);
            })
            {
                text = "Raise"
            });
            root.Add(runtimeWrapper);

            return root;
        }
#endif
    }
}
#endif
