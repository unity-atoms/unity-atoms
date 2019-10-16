using System;
using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Reference of type `GameObject`. Inherits from `AtomReference&lt;GameObject, GameObjectVariable, GameObjectConstant&gt;`.
    /// </summary>
    [Serializable]
    public sealed class GameObjectReference : AtomReference<
        GameObject,
        GameObjectVariable,
        GameObjectConstant> { }
}
