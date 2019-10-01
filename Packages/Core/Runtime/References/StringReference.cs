using System;

namespace UnityAtoms
{
    [Serializable]
    public sealed class StringReference : AtomReference<
        string,
        StringVariable>
    { }
}
