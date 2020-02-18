using System;
using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Reference of type `Color`. Inherits from `AtomReference&lt;Color, ColorConstant, ColorVariable, ColorEvent, ColorColorEvent, ColorColorFunction, ColorVariableInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class ColorReference : AtomReference<
        Color,
        ColorConstant,
        ColorVariable,
        ColorEvent,
        ColorColorEvent,
        ColorColorFunction,
        ColorVariableInstancer> { }
}
