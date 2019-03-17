using System;
using UnityEngine.Events;

namespace UnityAtoms
{
    [Serializable]
    public class UnityStringEvent : UnityEvent<string> { }

    [Serializable]
    public class UnityStringStringEvent : UnityEvent<string, string> { }
}