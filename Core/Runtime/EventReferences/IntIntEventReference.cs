using System;

namespace UnityAtoms
{
    /// <summary>
    /// Event x 2 Reference of type `int`. Inherits from `AtomEventX2Reference&lt;int, IntVariable, IntEvent, IntIntEvent, IntIntFunction, IntVariableInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class IntIntEventReference : AtomEventX2Reference<
        int,
        IntVariable,
        IntEvent,
        IntIntEvent,
        IntIntFunction,
        IntVariableInstancer> { }
}
