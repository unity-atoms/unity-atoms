using System;
using UnityAtoms.MonoHooks;

namespace UnityAtoms.MonoHooks
{
    /// <summary>
    /// Event Reference of type `Collider2DGameObject`. Inherits from `AtomEventReference&lt;Collider2DGameObject, Collider2DGameObjectVariable, Collider2DGameObjectEvent, Collider2DGameObjectVariableInstancer, Collider2DGameObjectEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class Collider2DGameObjectEventReference : AtomEventReference<
        Collider2DGameObject,
        Collider2DGameObjectVariable,
        Collider2DGameObjectEvent,
        Collider2DGameObjectVariableInstancer,
        Collider2DGameObjectEventInstancer>, IGetEvent 
    { }
}
