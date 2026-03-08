using UnityAtoms.Editor;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UIElements;

namespace UnityAtoms.Core.Editor
{

    [CustomEditor(typeof(AtomBaseListener), true)]
    public class EventReferenceListenerInspector : UnityEditor.Editor
    {

        public override VisualElement CreateInspectorGUI()
        {
            var root = new VisualElement();
            root.styleSheets.Add(AssetDatabase.LoadAssetAtPath<StyleSheet>(
                "Packages/com.unity-atoms.unity-atoms-core/Editor/Editors/EventReferenceListeners/UnityAtomsEventReferenceListenersUSS.uss"
            ));

// Readonly Script Reference
            root.Add(new PropertyField(serializedObject.FindProperty("m_Script"))
            {
                enabledSelf = false
            });
// -


            var prop_devDescr = serializedObject.FindProperty("_developerDescription");
            prop_devDescr.isExpanded = false;
            var devString = string.IsNullOrWhiteSpace(prop_devDescr.stringValue) ? "(click to edit dev notes)" : prop_devDescr.stringValue;

            VisualElement devNotesWrapper = new VisualElement();
            devNotesWrapper.AddToClassList("dev-notes-wrapper");
            var field_devNotesText = new Label(devString) { name = "dev-descr" };
            field_devNotesText.enableRichText = true;
            devNotesWrapper.Add(field_devNotesText);
            var field_devNotes = new PropertyField(prop_devDescr);
            field_devNotes.RegisterCallback<FocusOutEvent>(evt =>
            {
                prop_devDescr.isExpanded = false;
                field_devNotesText.style.display = DisplayStyle.Flex;
                field_devNotes.style.display = DisplayStyle.None;
                field_devNotesText.text = string.IsNullOrWhiteSpace(prop_devDescr.stringValue) ? "(click to edit dev notes)" : prop_devDescr.stringValue;
            });
            field_devNotesText.RegisterCallback<ClickEvent>(evt =>
            {
                prop_devDescr.isExpanded = true;
                field_devNotesText.style.display = DisplayStyle.None;
                field_devNotes.style.display = DisplayStyle.Flex;
            });
            field_devNotesText.style.display = !prop_devDescr.isExpanded ? DisplayStyle.Flex : DisplayStyle.None;
            field_devNotes.style.display = prop_devDescr.isExpanded ? DisplayStyle.Flex : DisplayStyle.None;
            devNotesWrapper.Add(field_devNotes);
            root.Add(devNotesWrapper);

            var prop_eventRef = serializedObject.FindProperty("_eventReference");
            root.Add(new PropertyField(prop_eventRef)
                {
                    tooltip = "Event being listened to"
                }
            );

            root.Add(new PropertyField(serializedObject.FindProperty("_replayEventBufferOnRegister")));

            // Foldable Group:Conditions
            var conditionWrapper = new VisualElement();

            var prop_conditions = serializedObject.FindProperty("_conditions");
            var field_condition = new PropertyField(prop_conditions);
            field_condition.AddToClassList("indented-list");
            var field_operator = new PropertyField(serializedObject.FindProperty("_operator"))
            {
                name = "atoms--nested-operator-dropdown"
            };

            field_operator.style.display = prop_conditions.isExpanded ? DisplayStyle.Flex : DisplayStyle.None;
            field_condition.RegisterCallback<ClickEvent>((evt) =>
            {
                field_operator.style.display = prop_conditions.isExpanded ? DisplayStyle.Flex : DisplayStyle.None;
            });

            conditionWrapper.Add(field_condition);
            conditionWrapper.Add(field_operator);

            root.Add(conditionWrapper);

            // -


            // Foldable Group:Responses

            var foldableGroup = new Foldout();
            foldableGroup.AddToClassList("foldout-border");
            foldableGroup.text = "Responses";

            var prop_unityEvtResponse = serializedObject.FindProperty("_unityEventResponse");
            var field_unityEvtResponse = new PropertyField(prop_unityEvtResponse);

            var prop_actionResponses = serializedObject.FindProperty("_actionResponses");
            var field_actionResponses = new PropertyField(prop_actionResponses);

            foldableGroup.Add(field_unityEvtResponse);
            foldableGroup.Add(field_actionResponses);

            root.Add(foldableGroup);

            // -



            return root;
        }
    }

}
