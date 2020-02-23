using System;
using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event x 2 Reference of type `Color`. Inherits from `AtomEventX2Reference&lt;Color, ColorVariable, ColorEvent, ColorColorEvent, ColorColorFunction, ColorVariableInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class ColorColorEventReference : AtomEventX2Reference<
        Color,
        ColorVariable,
        ColorEvent,
        ColorColorEvent,
        ColorColorFunction,
        ColorVariableInstancer> { }
}
