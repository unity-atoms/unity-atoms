using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UIElements;

namespace UnityAtoms.MonoHooks.Editor
{
    [CustomEditor(typeof(OnCollisionHook))]
    public class CollisionHookInspector : UnityEditor.Editor
    {
        [System.Flags]
        private enum CollisionEventFlags
        {
            OnCollisionEnter = 1,
            OnCollisionExit = 2,
            OnCollisionStay = 4
        }

        public override VisualElement CreateInspectorGUI()
        {
            var root = new VisualElement();
// Readonly Script Reference
            root.Add(new PropertyField(serializedObject.FindProperty("m_Script"))
            {
                enabledSelf = false
            });
// -


// Collision Lifecycle Hook
            var prop_flagOnColEnter = serializedObject.FindProperty("_collisionOnEnter");
            var prop_flagOnColExit = serializedObject.FindProperty("_collisionOnExit");
            var prop_flagOnColStay = serializedObject.FindProperty("_collisionOnStay");

            int combinedFlag =
                (1 * (prop_flagOnColEnter.boolValue ? 1 : 0)) +
                (2 * (prop_flagOnColExit.boolValue ? 1 : 0)) +
                (4 * (prop_flagOnColStay.boolValue ? 1 : 0));

            var flagsField = new EnumFlagsField((CollisionEventFlags)combinedFlag);
            flagsField.label = "Collision Event";
            flagsField.tooltip = "Select which callbacks should raise the event.";
            flagsField.labelElement.style.minWidth = 100;
            flagsField.RegisterValueChangedCallback((evt) =>
            {
                int newFlag = (int)(CollisionEventFlags)evt.newValue;

                prop_flagOnColEnter.boolValue = (newFlag & (int)CollisionEventFlags.OnCollisionEnter) != 0;
                prop_flagOnColExit.boolValue = (newFlag & (int)CollisionEventFlags.OnCollisionExit) != 0;
                prop_flagOnColStay.boolValue = (newFlag & (int)CollisionEventFlags.OnCollisionStay) != 0;

                serializedObject.ApplyModifiedProperties();
            });

            var wrapper = new VisualElement();
            flagsField.AddToClassList("unity-base-field__aligned");
            root.Add(flagsField);

//_Collision Lifecycle Hook

// Events
            var prop_eventNoArgs = serializedObject.FindProperty("_eventReference");
            root.Add(new PropertyField(prop_eventNoArgs)
                {
                    tooltip = "Event being raised"
                }
            );

            var prop_eventWithArg = serializedObject.FindProperty("_eventWithGameObjectReference");
            var field_eventWithArg = new PropertyField(prop_eventWithArg)
            {
                tooltip = "Event being raised with GameObject"
            };
            root.Add(field_eventWithArg);
//_Events

// Optional GO Selector
            var prop_gameObjectSelector = serializedObject.FindProperty("_selectGameObjectReference");
            var field_gameObjectSelector = new PropertyField(prop_gameObjectSelector);
            field_gameObjectSelector.tooltip = "AtomFunction called with *this* GameObject as argument that returns a GameObject to be passed into " + prop_eventWithArg.displayName
                + "\n Requires event to be added first";
            field_gameObjectSelector.style.marginLeft = 16;

            field_gameObjectSelector.SetEnabled(hasEventReferenceAValueSet(prop_eventWithArg));
            field_eventWithArg.RegisterValueChangeCallback((evt) =>
            {
                field_gameObjectSelector.SetEnabled(hasEventReferenceAValueSet(prop_eventWithArg));
            });

            root.Add(field_gameObjectSelector);

// _Optional GO Selector
            return root;
        }

        bool hasEventReferenceAValueSet(SerializedProperty prop)
        {
            switch (prop.FindPropertyRelative("_usage").intValue)
            {
                case AtomEventReferenceUsage.EVENT: return prop.FindPropertyRelative("_event").objectReferenceValue != null;
                case AtomEventReferenceUsage.VARIABLE: return prop.FindPropertyRelative("_variable").objectReferenceValue != null;
                case AtomEventReferenceUsage.EVENT_INSTANCER: return prop.FindPropertyRelative("_eventInstancer").objectReferenceValue != null;
                case AtomEventReferenceUsage.VARIABLE_INSTANCER: return prop.FindPropertyRelative("_variableInstancer").objectReferenceValue != null;
                default: return false;
            }
        }
    }


}
