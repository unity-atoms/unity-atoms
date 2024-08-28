#if PACKAGE_UNITY_PHYSICS
using System;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference of type `ColliderPair`. Inherits from `AtomEventReference&lt;ColliderPair, ColliderVariable, ColliderPairEvent, ColliderVariableInstancer, ColliderPairEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class ColliderPairEventReference : AtomEventReference<
        ColliderPair,
        ColliderVariable,
        ColliderPairEvent,
        ColliderVariableInstancer,
        ColliderPairEventInstancer>, IGetEvent 
    { }
}
#endif
