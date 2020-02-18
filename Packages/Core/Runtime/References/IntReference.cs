using System;

namespace UnityAtoms
{
    /// <summary>
    /// Reference of type `int`. Inherits from `AtomReference&lt;int, IntConstant, IntVariable, IntEvent, IntIntEvent, IntIntFunction, IntVariableInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class IntReference : AtomReference<
        int,
        IntConstant,
        IntVariable,
        IntEvent,
        IntIntEvent,
        IntIntFunction,
        IntVariableInstancer> { }
}
