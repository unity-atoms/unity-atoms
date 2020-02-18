namespace UnityAtoms.Editor
{
    /// <summary>
    /// Internal static class holding predefined static `AtomType`s.
    /// </summary>
    internal static class AtomTypes
    {
        public static readonly AtomType ACTION = new AtomType(type: "Action");
        public static readonly AtomType ACTION_X2 = new AtomType(type: "Action", displayName: "Action x 2", typeOccurences: 2);
        public static readonly AtomType CONSTANT = new AtomType(type: "Constant");
        public static readonly AtomType EVENT = new AtomType(type: "Event");
        public static readonly AtomType EVENT_X2 = new AtomType(type: "Event", displayName: "Event x 2", typeOccurences: 2);
        public static readonly AtomType LIST = new AtomType(type: "List");
        public static readonly AtomType LISTENER = new AtomType(type: "Listener");
        public static readonly AtomType LISTENER_X2 = new AtomType(type: "Listener", displayName: "Listener x 2", typeOccurences: 2);
        public static readonly AtomType REFERENCE = new AtomType(type: "Reference");
        public static readonly AtomType SET_VARIABLE_VALUE = new AtomType(type: "Set{TYPE_NAME}VariableValue", displayName: "Set Variable Value (Action)");
        public static readonly AtomType UNITY_EVENT = new AtomType(type: "UnityEvent", displayName: "Unity Event");
        public static readonly AtomType UNITY_EVENT_X2 = new AtomType(type: "UnityEvent", displayName: "Unity Event x 2", typeOccurences: 2);
        public static readonly AtomType VARIABLE = new AtomType(type: "Variable");
        public static readonly AtomType FUNCTION_X2 = new AtomType(type: "Function", displayName: "Function x 2", typeOccurences: 2);
        public static readonly AtomType VARIABLE_INSTANCER = new AtomType(type: "VariableInstancer", displayName: "Variable Instancer");
        public static readonly AtomType EVENT_REFERENCE = new AtomType(type: "EventReference", displayName: "Event Reference");
        public static readonly AtomType EVENT_X2_REFERENCE = new AtomType(type: "EventReference", displayName: "Event x 2 Reference", typeOccurences: 2);
    }
}
