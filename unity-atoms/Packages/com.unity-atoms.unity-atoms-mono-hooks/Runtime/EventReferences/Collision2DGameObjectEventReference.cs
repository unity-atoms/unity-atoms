using System;
using UnityAtoms.MonoHooks;

namespace UnityAtoms.MonoHooks
{
    /// <summary>
    /// Event Reference of type `Collision2DGameObject`. Inherits from `AtomEventReference&lt;Collision2DGameObject, Collision2DGameObjectVariable, Collision2DGameObjectEvent, Collision2DGameObjectVariableInstancer, Collision2DGameObjectEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class Collision2DGameObjectEventReference : AtomEventReference<
        Collision2DGameObject,
        Collision2DGameObjectVariable,
        Collision2DGameObjectEvent,
        Collision2DGameObjectVariableInstancer,
        Collision2DGameObjectEventInstancer>, IGetEvent 
    { }
}
