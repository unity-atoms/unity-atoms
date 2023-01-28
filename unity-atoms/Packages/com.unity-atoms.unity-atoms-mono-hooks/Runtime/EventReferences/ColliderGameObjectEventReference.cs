using System;
using UnityAtoms.MonoHooks;

namespace UnityAtoms.MonoHooks
{
    /// <summary>
    /// Event Reference of type `ColliderGameObject`. Inherits from `AtomEventReference&lt;ColliderGameObject, ColliderGameObjectVariable, ColliderGameObjectEvent, ColliderGameObjectVariableInstancer, ColliderGameObjectEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class ColliderGameObjectEventReference : AtomEventReference<
        ColliderGameObject,
        ColliderGameObjectVariable,
        ColliderGameObjectEvent,
        ColliderGameObjectVariableInstancer,
        ColliderGameObjectEventInstancer>, IGetEvent 
    { }
}
