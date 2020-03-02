using System;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference of type `bool`. Inherits from `AtomEventReference&lt;bool, BoolVariable, BoolEvent, BoolVariableInstancer, BoolEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class BoolEventReference : AtomEventReference<
        bool,
        BoolVariable,
        BoolEvent,
        BoolVariableInstancer,
        BoolEventInstancer>, IGetEvent 
    { }
}
