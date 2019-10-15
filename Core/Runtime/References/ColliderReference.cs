using System;
using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Reference of type `Collider`. Inherits from `AtomReference&lt;Collider, ColliderVariable&gt;`.
    /// </summary>
    [Serializable]
    public sealed class ColliderReference : AtomReference<
        Collider,
        ColliderVariable> { }
}
