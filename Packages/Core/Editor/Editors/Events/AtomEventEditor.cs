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
        static string RAISE_VALUE_PROPNAME = "_raiseValue";

        public override VisualElement CreateInspectorGUI()
        {
            var root = new VisualElement();

            IMGUIContainer defaultInspector = new IMGUIContainer(() => DrawDefaultInspector());
            root.Add(defaultInspector);

            var runtimeWrapper = new VisualElement();
            runtimeWrapper.SetEnabled(Application.isPlaying);
            runtimeWrapper.Add(new Button(() =>
            {
                E e = target as E;
                var raiseValueProp = serializedObject.FindProperty(RAISE_VALUE_PROPNAME);
                e.Raise((T)raiseValueProp.GetPropertyValue());
            })
            {
                text = "Raise"
            });
            root.Add(runtimeWrapper);

            return root;
        }
    }

    /// <summary>
    /// Custom editor for Events. Adds the possiblity to raise an Event from Unity's Inspector.
    /// </summary>
    /// <typeparam name="T1">The first type of this Event.</typeparam>
    /// <typeparam name="T2">The second type of this Event.</typeparam>
    /// <typeparam name="E">Event of type T1 and T2.</typeparam>
    public abstract class AtomEventEditor<T1, T2, E> : UnityEditor.Editor
        where E : AtomEvent<T1, T2>
    {
        static string RAISE_VALUE_1_PROPNAME = "_raiseValue1";
        static string RAISE_VALUE_2_PROPNAME = "_raiseValue2";

        public override VisualElement CreateInspectorGUI()
        {
            var root = new VisualElement();

            IMGUIContainer defaultInspector = new IMGUIContainer(() => DrawDefaultInspector());
            root.Add(defaultInspector);

            var runtimeWrapper = new VisualElement();
            runtimeWrapper.SetEnabled(Application.isPlaying);
            runtimeWrapper.Add(new Button(() =>
            {
                E e = target as E;
                var raiseValue1Prop = serializedObject.FindProperty(RAISE_VALUE_1_PROPNAME);
                var raiseValue2Prop = serializedObject.FindProperty(RAISE_VALUE_2_PROPNAME);
                e.Raise((T1)raiseValue1Prop.GetPropertyValue(), (T2)raiseValue2Prop.GetPropertyValue());
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
