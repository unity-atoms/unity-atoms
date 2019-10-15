using System;

namespace UnityAtoms
{
    /// <summary>
    /// Reference of type `float`. Inherits from `AtomReference&lt;float, FloatVariable&gt;`.
    /// </summary>
    [Serializable]
    public sealed class FloatReference : AtomReference<
        float,
        FloatVariable> { }
}
