using System;

namespace UnityAtoms
{
    [Serializable]
    public sealed class BoolReference : ScriptableObjectReference<
        bool,
        BoolVariable> { }
}
