using System;

namespace UnityAtoms
{
    [Serializable]
    public sealed class BoolReference : AtomReference<
        bool,
        BoolVariable>
    { }
}
