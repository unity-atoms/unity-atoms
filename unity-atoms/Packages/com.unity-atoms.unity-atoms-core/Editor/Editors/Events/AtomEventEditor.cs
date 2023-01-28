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
    public abstract class AtomEventEditor<T, E> : UnityEditor.Editor
        where E : AtomEvent<T>
    {
        public override VisualElement CreateInspectorGUI()
        {
            var root = new VisualElement();

            IMGUIContainer defaultInspector = new IMGUIContainer(() => DrawDefaultInspector());
            root.Add(defaultInspector);

            E atomEvent = target as E;

            var runtimeWrapper = new VisualElement();
            runtimeWrapper.SetEnabled(Application.isPlaying);
            runtimeWrapper.Add(new Button(() =>
            {
                atomEvent.Raise(atomEvent.InspectorRaiseValue);
            })
            {
                text = "Raise"
            });
            root.Add(runtimeWrapper);

#if !UNITY_ATOMS_GENERATE_DOCS
            StackTraceEditor.RenderStackTrace(root, atomEvent.GetInstanceID());
#endif

            return root;
        }
    }
}
#endif
