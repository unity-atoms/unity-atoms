using System;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference of type `ColorPair`. Inherits from `AtomEventReference&lt;ColorPair, ColorVariable, ColorPairEvent, ColorVariableInstancer, ColorPairEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class ColorPairEventReference : AtomEventReference<
        ColorPair,
        ColorVariable,
        ColorPairEvent,
        ColorVariableInstancer,
        ColorPairEventInstancer>, IGetEvent 
    { }
}
