using System;

namespace UnityAtoms
{
    /// <summary>
    /// Reference of type `bool`. Inherits from `AtomReference&lt;bool, BoolConstant, BoolVariable, BoolEvent, BoolBoolEvent, BoolBoolFunction, BoolVariableInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class BoolReference : AtomReference<
        bool,
        BoolConstant,
        BoolVariable,
        BoolEvent,
        BoolBoolEvent,
        BoolBoolFunction,
        BoolVariableInstancer> { }
}
