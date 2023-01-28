#if UNITY_2019_1_OR_NEWER
using UnityEngine;
using UnityEngine.UIElements;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Custom editor for Events. Adds the possiblity to raise an Event from Unity's Inspector.
    /// </summary>
    /// <typeparam name="T">The type of this event..</typeparam>
    /// <typeparam name="E">Event of type T.</typeparam>
    public abstract class AtomEventInstancerEditor<T, E> : UnityEditor.Editor
        where E : AtomEvent<T>
    {
        public override VisualElement CreateInspectorGUI()
        {
            var root = new VisualElement();

            IMGUIContainer defaultInspector = new IMGUIContainer(() => DrawDefaultInspector());
            root.Add(defaultInspector);

            var eventInstancer = target as AtomEventInstancer<T, E>;
            E atomEvent = eventInstancer.Event;

            var runtimeWrapper = new VisualElement();
            runtimeWrapper.SetEnabled(Application.isPlaying);
            runtimeWrapper.Add(new Button(() =>
            {
                atomEvent.Raise(eventInstancer.InspectorRaiseValue);
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
