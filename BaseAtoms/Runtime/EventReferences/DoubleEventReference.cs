using System;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference of type `double`. Inherits from `AtomEventReference&lt;double, DoubleVariable, DoubleEvent, DoubleVariableInstancer, DoubleEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class DoubleEventReference : AtomEventReference<
        double,
        DoubleVariable,
        DoubleEvent,
        DoubleVariableInstancer,
        DoubleEventInstancer>, IGetEvent 
    { }
}
