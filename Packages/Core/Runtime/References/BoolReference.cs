using System;

namespace UnityAtoms
{
    /// <summary>
    /// Reference of type `bool`. Inherits from `AtomReference&lt;bool, BoolVariable, BoolConstant&gt;`.
    /// </summary>
    [Serializable]
    public sealed class BoolReference : AtomReference<
        bool,
        BoolVariable,
        BoolConstant> { }
}
