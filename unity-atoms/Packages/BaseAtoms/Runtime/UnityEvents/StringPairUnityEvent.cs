using System;
using UnityEngine.Events;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// None generic Unity Event of type `StringPair`. Inherits from `UnityEvent&lt;StringPair&gt;`.
    /// </summary>
    [Serializable]
    public sealed class StringPairUnityEvent : UnityEvent<StringPair> { }
}
