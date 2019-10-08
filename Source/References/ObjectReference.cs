using System;

namespace UnityAtoms
{
    [Serializable]
    public sealed class ObjectReference : AtomReference<
        object,
        ObjectVariable> { }
}
