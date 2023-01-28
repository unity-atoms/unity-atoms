using System;
using UnityAtoms.MonoHooks;

namespace UnityAtoms.MonoHooks
{
    /// <summary>
    /// Event Reference of type `CollisionGameObject`. Inherits from `AtomEventReference&lt;CollisionGameObject, CollisionGameObjectVariable, CollisionGameObjectEvent, CollisionGameObjectVariableInstancer, CollisionGameObjectEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class CollisionGameObjectEventReference : AtomEventReference<
        CollisionGameObject,
        CollisionGameObjectVariable,
        CollisionGameObjectEvent,
        CollisionGameObjectVariableInstancer,
        CollisionGameObjectEventInstancer>, IGetEvent 
    { }
}
