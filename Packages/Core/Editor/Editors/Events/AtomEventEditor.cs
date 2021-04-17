using System;
using System.Reflection;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Custom editor for Events. Adds the possiblity to raise an Event from Unity's Inspector.
    /// </summary>
    [CustomEditor(typeof(AtomEvent<>), true)]
    public class AtomEventEditor : UnityEditor.Editor
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
                var inspectorRaiseValueProperty = targetType.GetProperty(nameof(AtomEvent<object>.InspectorRaiseValue), BindingFlags.Instance | BindingFlags.Public);
                var inspectorRaiseValue = inspectorRaiseValueProperty.GetValue(target);
                var raiseMethod = targetType.GetMethod(nameof(AtomEvent<object>.Raise), new[] { inspectorRaiseValueProperty.PropertyType });
                raiseMethod.Invoke(target, new[] { inspectorRaiseValue });
            })
            {
                text = "Raise"
            });
            root.Add(runtimeWrapper);

            return root;
        }
    }
}
