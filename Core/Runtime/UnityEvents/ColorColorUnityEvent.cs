using System;
using UnityEngine.Events;
using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// None generic Unity Event x 2 of type `Color`. Inherits from `UnityEvent&lt;Color, Color&gt;`.
    /// </summary>
    [Serializable]
    public sealed class ColorColorUnityEvent : UnityEvent<Color, Color> { }
}
