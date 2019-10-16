using System;

namespace UnityAtoms
{
    /// <summary>
    /// Reference of type `int`. Inherits from `AtomReference&lt;int, IntVariable, IntConstant&gt;`.
    /// </summary>
    [Serializable]
    public sealed class IntReference : AtomReference<
        int,
        IntVariable,
        IntConstant> { }
}
