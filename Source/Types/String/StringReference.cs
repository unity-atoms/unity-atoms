using System;

namespace UnityAtoms
{
    [Serializable]
    public sealed class StringReference : ScriptableObjectReference<
        string,
        StringVariable>
    { }
}
