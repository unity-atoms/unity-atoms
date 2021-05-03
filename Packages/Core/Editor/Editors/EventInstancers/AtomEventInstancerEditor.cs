using System.Reflection;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

namespace UnityAtoms.Editor
{
    ///// <summary>
    ///// Custom editor for Events. Adds the possiblity to raise an Event from Unity's Inspector.
    ///// </summary>
    [CustomEditor(typeof(AtomEventInstancer<>), true)]
    public class AtomEventInstancerEditor : UnityEditor.Editor
    {
        public override VisualElement CreateInspectorGUI()
        {
            var root = new VisualElement();

            IMGUIContainer defaultInspector = new IMGUIContainer(() => DrawDefaultInspector());
            root.Add(defaultInspector);

            var runtimeWrapper = new VisualElement();
            runtimeWrapper.SetEnabled(Application.isPlaying);
            runtimeWrapper.Add(new Button(() =>
            {
                var targetType = target.GetType();
                var atomEventInstancerEventProperty = targetType.GetProperty(nameof(AtomEventInstancer<object>.Event), BindingFlags.Instance | BindingFlags.Public);
                var atomEventInstancerEvent = atomEventInstancerEventProperty.GetValue(target);

                var atomEventInstancerEventType = atomEventInstancerEvent.GetType();
                var inspectorRaiseValueProperty = atomEventInstancerEventType.GetProperty(nameof(AtomEvent<object>.InspectorRaiseValue), BindingFlags.Instance | BindingFlags.Public);
                var inspectorRaiseValue = inspectorRaiseValueProperty.GetValue(atomEventInstancerEvent);

                var raiseMethod = atomEventInstancerEventType.GetMethod(nameof(AtomEvent<object>.Raise), new[] { inspectorRaiseValueProperty.PropertyType });
                raiseMethod.Invoke(atomEventInstancerEvent, new[] { inspectorRaiseValue });
            })
            {
                text = "Raise",
            });
            root.Add(runtimeWrapper);

            return root;
        }
    }
}
