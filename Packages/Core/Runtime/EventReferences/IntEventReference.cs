using System;

namespace UnityAtoms
{
    /// <summary>
    /// Event Reference of type `int`. Inherits from `AtomEventReference&lt;int, IntVariable, IntEvent, IntIntEvent, IntIntFunction, IntVariableInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class IntEventReference : AtomEventReference<
        int,
        IntVariable,
        IntEvent,
        IntIntEvent,
        IntIntFunction,
        IntVariableInstancer> { }
}
