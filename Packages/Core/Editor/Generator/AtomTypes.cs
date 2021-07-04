using System.IO;
using System.Collections.Generic;
using System;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Internal static class holding predefined static `AtomType`s.
    /// </summary>
    [Obsolete("AtomTypes is being deprecated for a Type based workflow.", false)]
    internal static class AtomTypes
    {
        public static readonly AtomType CONSTANT = new AtomType(
            displayName: "Constant",
            templateName: "UA_Template__Constant.txt"
        );
        public static readonly AtomType EVENT = new AtomType(
            displayName: "Event",
            templateName: "UA_Template__Event.txt"
        );
        public static readonly AtomType PAIR_EVENT = new AtomType(
            displayName: "Pair Event",
            name: "Event",
            templateName: "UA_Template__Event.txt"
        );
        public static readonly AtomType VALUE_LIST = new AtomType(
            displayName: "Value List",
            templateName: "UA_Template__ValueList.txt"
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
        public static readonly AtomType VARIABLE = new AtomType(
            displayName: "Variable",
            templateName: "UA_Template__Variable.txt"
        );
        public static readonly AtomType VARIABLE_INSTANCER = new AtomType(
            displayName: "Variable Instancer",
            name: "VariableInstancer",
            templateName: "UA_Template__VariableInstancer.txt"
        );
        public static readonly AtomType EVENT_INSTANCER = new AtomType(
            displayName: "Event Instancer",
            templateName: "UA_Template__EventInstancer.txt",
            editorTemplateName: "UA_Template_AtomEditor__EventInstancer.txt"
        );
        public static readonly AtomType PAIR_EVENT_INSTANCER = new AtomType(
            displayName: "Pair Event Instancer",
            name: "EventInstancer",
            templateName: "UA_Template__EventInstancer.txt"
        );

        /// <summary>
        /// Containes all common atom types that are usually generated for a type.
        /// </summary>
        public static readonly List<AtomType> ALL_ATOM_TYPES = new List<AtomType>()
        {
            AtomTypes.CONSTANT,
            AtomTypes.EVENT,
            AtomTypes.PAIR_EVENT,
            AtomTypes.VALUE_LIST,
            AtomTypes.EVENT_REFERENCE_LISTENER,
            AtomTypes.PAIR_EVENT_REFERENCE_LISTENER,
            AtomTypes.SET_VARIABLE_VALUE,
            AtomTypes.SYNC_VARIABLE_INSTANCER_TO_COLLECTION,
            AtomTypes.VARIABLE,
            AtomTypes.VARIABLE_INSTANCER,
            AtomTypes.EVENT_INSTANCER,
            AtomTypes.PAIR_EVENT_INSTANCER,
        };
    }
}
