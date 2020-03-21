using System.IO;
using System.Collections.Generic;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Internal static class holding predefined static `AtomType`s.
    /// </summary>
    internal static class AtomTypes
    {
        public static readonly AtomType ACTION = new AtomType(
            displayName: "Action",
            templateName: "UA_Template__Action.txt"
        );
        public static readonly AtomType PAIR_ACTION = new AtomType(
            displayName: "Pair Action",
            name: "Action",
            templateName: "UA_Template__Action.txt"
        );
        public static readonly AtomType CONSTANT = new AtomType(
            displayName: "Constant",
            templateName: "UA_Template__Constant.txt",
            drawerTemplateName: "UA_Template_AtomDrawer__Constant.txt"
        );
        public static readonly AtomType EVENT = new AtomType(
            displayName: "Event",
            templateName: "UA_Template__Event.txt",
            drawerTemplateName: "UA_Template_AtomDrawer__Event.txt",
            editorTemplateName: "UA_Template_AtomEditor__Event.txt"
        );
        public static readonly AtomType PAIR_EVENT = new AtomType(
            displayName: "Pair Event",
            name: "Event",
            templateName: "UA_Template__Event.txt",
            drawerTemplateName: "UA_Template_AtomDrawer__Event.txt",
            editorTemplateName: "UA_Template_AtomEditor__Event.txt"
        );
        public static readonly AtomType VALUE_LIST = new AtomType(
            displayName: "Value List",
            templateName: "UA_Template__ValueList.txt",
            drawerTemplateName: "UA_Template_AtomDrawer__ValueList.txt"
        );
        // BASE_EVENT_REFERENCE_LISTENER is only used in thoses cases where a Variable does not make sense, eg. Void.
        public static readonly AtomType BASE_EVENT_REFERENCE_LISTENER = new AtomType(
            displayName: "Base Event Reference Listener",
            templateName: "UA_Template__BaseEventReferenceListener.txt"
        );
        public static readonly AtomType EVENT_REFERENCE_LISTENER = new AtomType(
            displayName: "Event Reference Listener",
            templateName: "UA_Template__EventReferenceListener.txt"
        );
        public static readonly AtomType PAIR_EVENT_REFERENCE_LISTENER = new AtomType(
            displayName: "Pair Event Reference Listener",
            name: "EventReferenceListener",
            templateName: "UA_Template__EventReferenceListener.txt"
        );
        // EVENT_LISTENER is only used in thoses cases where a Event Reference listener does not make sense, eg. AtomBaseVariable.
        public static readonly AtomType EVENT_LISTENER = new AtomType(
            displayName: "Event Listener",
            name: "EventListener",
            templateName: "UA_Template__EventListener.txt"
        );
        public static readonly AtomType REFERENCE = new AtomType(
            displayName: "Reference",
            templateName: "UA_Template__Reference.txt"
        );
        // BASE_EVENT_REFERENCE is only used in thoses cases where a Variable does not make sense, eg. Void.
        public static readonly AtomType BASE_EVENT_REFERENCE = new AtomType(
            displayName: "Base Event Reference",
            templateName: "UA_Template__BaseEventReference.txt"
        );
        public static readonly AtomType EVENT_REFERENCE = new AtomType(
            displayName: "Event Reference",
            templateName: "UA_Template__EventReference.txt"
        );
        public static readonly AtomType PAIR_EVENT_REFERENCE = new AtomType(
            displayName: "Pair Event Reference",
            name: "EventReference",
            templateName: "UA_Template__EventReference.txt"
        );
        public static readonly AtomType SET_VARIABLE_VALUE = new AtomType(
            displayName: "Set Variable Value (string) => {}",
            name: "SetVariableValue",
            templateName: "UA_Template__SetVariableValue.txt",
            relativeFileNameAndPath: Path.Combine(Runtime.IsUnityAtomsRepo ? "Runtime" : "", "Actions", "SetVariableValue", $"Set{{VALUE_TYPE_NAME}}VariableValue.cs")
        );
        public static readonly AtomType SYNC_VARIABLE_INSTANCER_TO_COLLECTION = new AtomType(
            displayName: "Sync Variable Instancer To Collection",
            templateName: "UA_Template__SyncVariableInstancerToCollection.txt",
            relativeFileNameAndPath: Path.Combine(Runtime.IsUnityAtomsRepo ? "Runtime" : "", "SyncVariableInstancerToCollection", $"Sync{{VALUE_TYPE_NAME}}VariableInstancerToCollection.cs")
        );
        public static readonly AtomType UNITY_EVENT = new AtomType(
            displayName: "Unity Event",
            templateName: "UA_Template__UnityEvent.txt"
        );
        public static readonly AtomType PAIR_UNITY_EVENT = new AtomType(
            displayName: "Pair Unity Event",
            name: "UnityEvent",
            templateName: "UA_Template__UnityEvent.txt"
        );
        public static readonly AtomType VARIABLE = new AtomType(
            displayName: "Variable",
            templateName: "UA_Template__Variable.txt",
            drawerTemplateName: "UA_Template_AtomDrawer__Variable.txt",
            editorTemplateName: "UA_Template_AtomEditor__Variable.txt"
        );
        public static readonly AtomType FUNCTION_T_T = new AtomType(
            displayName: "Function (T) => T",
            name: "Function",
            templateName: "UA_Template__FunctionTT.txt",
            relativeFileNameAndPath: Path.Combine(Runtime.IsUnityAtomsRepo ? "Runtime" : "", "Functions", $"{{VALUE_TYPE_NAME}}{{VALUE_TYPE_NAME}}Function.cs")
        );
        public static readonly AtomType VARIABLE_INSTANCER = new AtomType(
            displayName: "Variable Instancer",
            name: "VariableInstancer",
            templateName: "UA_Template__VariableInstancer.txt"
        );
        public static readonly AtomType EVENT_INSTANCER = new AtomType(
            displayName: "Event Instancer",
            templateName: "UA_Template__EventInstancer.txt"
        );
        public static readonly AtomType PAIR_EVENT_INSTANCER = new AtomType(
            displayName: "Pair Event Instancer",
            name: "EventInstancer",
            templateName: "UA_Template__EventInstancer.txt"
        );
        public static readonly AtomType PAIR = new AtomType(
            displayName: "Pair",
            templateName: "UA_Template__Pair.txt"
        );

        /// <summary>
        /// Containes all common atom types that are usually generated for a type.
        /// </summary>
        public static readonly List<AtomType> ALL_ATOM_TYPES = new List<AtomType>()
        {
            AtomTypes.ACTION,
            AtomTypes.PAIR_ACTION,
            AtomTypes.CONSTANT,
            AtomTypes.EVENT,
            AtomTypes.PAIR_EVENT,
            AtomTypes.VALUE_LIST,
            AtomTypes.EVENT_REFERENCE_LISTENER,
            AtomTypes.PAIR_EVENT_REFERENCE_LISTENER,
            AtomTypes.REFERENCE,
            AtomTypes.EVENT_REFERENCE,
            AtomTypes.PAIR_EVENT_REFERENCE,
            AtomTypes.SET_VARIABLE_VALUE,
            AtomTypes.SYNC_VARIABLE_INSTANCER_TO_COLLECTION,
            AtomTypes.UNITY_EVENT,
            AtomTypes.PAIR_UNITY_EVENT,
            AtomTypes.VARIABLE,
            AtomTypes.FUNCTION_T_T,
            AtomTypes.VARIABLE_INSTANCER,
            AtomTypes.EVENT_INSTANCER,
            AtomTypes.PAIR_EVENT_INSTANCER,
            AtomTypes.PAIR
        };

        /// <summary>
        /// Graph explaining all the dependencies between Atoms.
        /// </summary>
        public static readonly Dictionary<AtomType, List<AtomType>> DEPENDENCY_GRAPH = new Dictionary<AtomType, List<AtomType>>()
        {
            { AtomTypes.PAIR_ACTION, new List<AtomType>() { AtomTypes.PAIR } },
            { AtomTypes.PAIR_EVENT, new List<AtomType>() { AtomTypes.PAIR } },
            { AtomTypes.VALUE_LIST, new List<AtomType>() { AtomTypes.EVENT } },
            { AtomTypes.BASE_EVENT_REFERENCE_LISTENER, new List<AtomType>() { AtomTypes.EVENT, AtomTypes.BASE_EVENT_REFERENCE, AtomTypes.UNITY_EVENT, AtomTypes.ACTION } },
            { AtomTypes.EVENT_REFERENCE_LISTENER, new List<AtomType>() {
                AtomTypes.EVENT, AtomTypes.EVENT_REFERENCE, AtomTypes.UNITY_EVENT, AtomTypes.ACTION }
            },
            { AtomTypes.PAIR_EVENT_REFERENCE_LISTENER, new List<AtomType>() {
                AtomTypes.PAIR_EVENT, AtomTypes.PAIR_EVENT_REFERENCE, AtomTypes.PAIR_UNITY_EVENT, AtomTypes.PAIR_ACTION }
            },
            { AtomTypes.REFERENCE, new List<AtomType>() {
                AtomTypes.CONSTANT, AtomTypes.VARIABLE, AtomTypes.EVENT, AtomTypes.PAIR_EVENT, AtomTypes.FUNCTION_T_T, AtomTypes.VARIABLE_INSTANCER, AtomTypes.PAIR }
            },
            { AtomTypes.BASE_EVENT_REFERENCE, new List<AtomType>() {AtomTypes.EVENT, AtomTypes.EVENT_INSTANCER }
            },
            { AtomTypes.EVENT_REFERENCE, new List<AtomType>() { AtomTypes.VARIABLE, AtomTypes.EVENT, AtomTypes.VARIABLE_INSTANCER, AtomTypes.EVENT_INSTANCER }
            },
            { AtomTypes.PAIR_EVENT_REFERENCE, new List<AtomType>() { AtomTypes.VARIABLE, AtomTypes.PAIR_EVENT, AtomTypes.VARIABLE_INSTANCER, AtomTypes.PAIR_EVENT_INSTANCER }
            },
            { AtomTypes.SET_VARIABLE_VALUE, new List<AtomType>() {
                AtomTypes.EVENT, AtomTypes.PAIR_EVENT, AtomTypes.FUNCTION_T_T, AtomTypes.VARIABLE, AtomTypes.CONSTANT,
                AtomTypes.REFERENCE, AtomTypes.VARIABLE_INSTANCER, AtomTypes.PAIR }
            },
            { AtomTypes.SYNC_VARIABLE_INSTANCER_TO_COLLECTION, new List<AtomType>() {
                AtomTypes.VARIABLE, AtomTypes.VARIABLE_INSTANCER }
            },
            { AtomTypes.PAIR_UNITY_EVENT, new List<AtomType>() { AtomTypes.PAIR } },
            { AtomTypes.VARIABLE, new List<AtomType>() { AtomTypes.EVENT, AtomTypes.PAIR_EVENT, AtomTypes.FUNCTION_T_T, AtomTypes.PAIR } },
            { AtomTypes.VARIABLE_INSTANCER, new List<AtomType>() { AtomTypes.VARIABLE, AtomTypes.EVENT, AtomTypes.PAIR_EVENT, AtomTypes.FUNCTION_T_T, AtomTypes.PAIR } },
            { AtomTypes.EVENT_INSTANCER, new List<AtomType>() { AtomTypes.EVENT } },
            { AtomTypes.PAIR_EVENT_INSTANCER, new List<AtomType>() { AtomTypes.PAIR_EVENT } }
        };
    }
}
