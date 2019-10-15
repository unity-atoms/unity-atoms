using System;

namespace UnityAtoms
{
    /// <summary>
    /// Reference of type `string`. Inherits from `AtomReference&lt;string, StringVariable&gt;`.
    /// </summary>
    [Serializable]
    public sealed class StringReference : AtomReference<
        string,
        StringVariable> { }
}
