using System;
using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event Reference of type `Color`. Inherits from `AtomEventReference&lt;Color, ColorVariable, ColorEvent, ColorColorEvent, ColorColorFunction, ColorVariableInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class ColorEventReference : AtomEventReference<
        Color,
        ColorVariable,
        ColorEvent,
        ColorColorEvent,
        ColorColorFunction,
        ColorVariableInstancer> { }
}
