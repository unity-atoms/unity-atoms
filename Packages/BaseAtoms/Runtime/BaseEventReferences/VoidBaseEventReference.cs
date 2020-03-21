using System;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference of type `Void`. Inherits from `AtomBaseEventReference&lt;Void, VoidEvent, VoidEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class VoidBaseEventReference : AtomBaseEventReference<
        Void,
        VoidEvent,
        VoidEventInstancer>, IGetEvent
    { }
}
