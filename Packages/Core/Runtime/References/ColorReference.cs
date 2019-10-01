using System;
using UnityEngine;

namespace UnityAtoms
{
    [Serializable]
    public sealed class ColorReference : AtomReference<
        Color,
        ColorVariable>
    { }
}
