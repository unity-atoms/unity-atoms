using System;
using System.Reflection;
using UnityEditor;
using UnityEngine;
using UnityAtoms.Editor;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms.FSM.Editor
{
    /// <summary>
    /// Custom property drawer for type `FiniteStateMachine`. 
    /// </summary>
    [CustomEditor(typeof(FiniteStateMachine))]
    public sealed class FiniteStateMachineEditor : UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            serializedObject.Update();

            EditorGUILayout.PropertyField(serializedObject.FindProperty("_developerDescription"));
            EditorGUILayout.Space();

            EditorGUILayout.PropertyField(serializedObject.FindProperty("_id"));

            EditorGUI.BeginDisabledGroup(true);
            EditorGUILayout.PropertyField(serializedObject.FindProperty("_initialValue"), true);
            EditorGUI.EndDisabledGroup();

            EditorGUI.BeginDisabledGroup(true);
            EditorGUILayout.PropertyField(serializedObject.FindProperty("_value"), true);
            EditorGUI.EndDisabledGroup();

            EditorGUI.BeginDisabledGroup(true);
            EditorGUILayout.PropertyField(serializedObject.FindProperty("_oldValue"), true);
            EditorGUI.EndDisabledGroup();

            const int raiseButtonWidth = 52;
            using (new EditorGUILayout.HorizontalScope())
            {
                EditorGUILayout.PropertyField(serializedObject.FindProperty("Changed"));
                var changed = serializedObject.FindProperty("Changed").objectReferenceValue;
                if (changed != null && changed is AtomEventBase evt && target is AtomBaseVariable atomTarget)
                {
                    GUILayout.Space(2);
                    if (GUILayout.Button("Raise", GUILayout.Width(raiseButtonWidth), GUILayout.Height(EditorGUIUtility.singleLineHeight)))
                    {
                        evt.GetType().GetMethod("RaiseEditor", BindingFlags.Public | BindingFlags.Instance)?.Invoke(evt, new[] { atomTarget.BaseValue });
                    }
                }

            }

            using (new EditorGUILayout.HorizontalScope())
            {
                EditorGUILayout.PropertyField(serializedObject.FindProperty("ChangedWithHistory"));
                var changedWithHistory = serializedObject.FindProperty("ChangedWithHistory").objectReferenceValue;
                if (changedWithHistory != null && changedWithHistory is AtomEventBase evt && target is AtomBaseVariable atomTarget)
                {

                    GUILayout.Space(2);
                    if (GUILayout.Button("Raise", GUILayout.Width(raiseButtonWidth), GUILayout.Height(EditorGUIUtility.singleLineHeight)))
                    {
                        var oldValueProp = serializedObject.FindProperty("_oldValue");
                        object oldValue = oldValueProp.GetPropertyValue();
                        evt.GetType().GetMethod("RaiseEditor", BindingFlags.Public | BindingFlags.Instance)?.Invoke(evt, new[] { (object)(new StringPair() { Item1 = (string)atomTarget.BaseValue, Item2 = (string)oldValue }) });
                    }
                }

            }

            var transitionStartedProp = serializedObject.FindProperty("_transitionStarted");
            EditorGUILayout.PropertyField(transitionStartedProp, new GUIContent() { tooltip = "Event raised when a transition is started.", text = transitionStartedProp.displayName }, true);

            var completeCurrentTransitionProp = serializedObject.FindProperty("_completeCurrentTransition");
            EditorGUILayout.PropertyField(completeCurrentTransitionProp, new GUIContent() { tooltip = "A Bool Event that is passed along in the Transition Started event (an event that is required when using this event). The transition needs also to be marked with 'Raise Event To Complete Transition in order to use this event.'", text = completeCurrentTransitionProp.displayName }, true);

            EditorGUILayout.PropertyField(serializedObject.FindProperty("_states"), true);
            EditorGUILayout.PropertyField(serializedObject.FindProperty("_transitions"), true);

            serializedObject.ApplyModifiedProperties();
        }
    }
}
