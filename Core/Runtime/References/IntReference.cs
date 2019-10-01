using System;

namespace UnityAtoms
{
    [Serializable]
    public sealed class IntReference : AtomReference<
        int,
        IntVariable>
    { }
}
