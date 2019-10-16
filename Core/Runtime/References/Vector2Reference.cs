using System;
using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Reference of type `Vector2`. Inherits from `AtomReference&lt;Vector2, Vector2Variable, Vector2Constant&gt;`.
    /// </summary>
    [Serializable]
    public sealed class Vector2Reference : AtomReference<
        Vector2,
        Vector2Variable,
        Vector2Constant> { }
}
