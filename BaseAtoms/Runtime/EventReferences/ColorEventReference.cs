using System;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference of type `Color`. Inherits from `AtomEventReference&lt;Color, ColorVariable, ColorEvent, ColorVariableInstancer, ColorEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class ColorEventReference : AtomEventReference<
        Color,
        ColorVariable,
        ColorEvent,
        ColorVariableInstancer,
        ColorEventInstancer>, IGetEvent 
    { }
}
