#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEditor.UIElements;

namespace UnityAtoms.Editor
{
    public abstract class AtomEventEditor<T, E> : UnityEditor.Editor
        where E : AtomEvent<T>
    {
        protected T _raiseValue = default(T);

        protected virtual VisualElement GetRaiseValueInput() { return null; }

        public override VisualElement CreateInspectorGUI()
        {
            var wrapper = new VisualElement();
            wrapper.SetEnabled(Application.isPlaying);

            var input = GetRaiseValueInput();
            if (input != null)
            {
                wrapper.Add(input);
            }

            wrapper.Add(new Button(() =>
            {
                E e = target as E;
                e.Raise(_raiseValue);
            })
            {
                text = "Raise"
            });

            return wrapper;
        }
    }
}
#endif
