using System;

namespace UnityAtoms
{
    [Serializable]
    public sealed class ObjectReference : ScriptableObjectReference<
        object,
        ObjectVariable> { }
}
