using System;
using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Reference of type `Vector3`. Inherits from `AtomReference&lt;Vector3, Vector3Variable, Vector3Constant&gt;`.
    /// </summary>
    [Serializable]
    public sealed class Vector3Reference : AtomReference<
        Vector3,
        Vector3Variable,
        Vector3Constant> { }
}
