using System;

namespace UnityAtoms
{
    /// <summary>
    /// Event Reference of type `bool`. Inherits from `AtomEventReference&lt;bool, BoolVariable, BoolEvent, BoolBoolEvent, BoolBoolFunction, BoolVariableInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class BoolEventReference : AtomEventReference<
        bool,
        BoolVariable,
        BoolEvent,
        BoolBoolEvent,
        BoolBoolFunction,
        BoolVariableInstancer> { }
}
