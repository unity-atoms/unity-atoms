using System;
using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Reference of type `Color`. Inherits from `AtomReference&lt;Color, ColorVariable, ColorConstant&gt;`.
    /// </summary>
    [Serializable]
    public sealed class ColorReference : AtomReference<
        Color,
        ColorVariable,
        ColorConstant> { }
}
