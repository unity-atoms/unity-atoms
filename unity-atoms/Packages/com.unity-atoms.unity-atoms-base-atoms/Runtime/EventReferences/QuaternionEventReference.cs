using System;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference of type `Quaternion`. Inherits from `AtomEventReference&lt;Quaternion, QuaternionVariable, QuaternionEvent, QuaternionVariableInstancer, QuaternionEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class QuaternionEventReference : AtomEventReference<
        Quaternion,
        QuaternionVariable,
        QuaternionEvent,
        QuaternionVariableInstancer,
        QuaternionEventInstancer>, IGetEvent 
    { }
}
