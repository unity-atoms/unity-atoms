using System;

namespace UnityAtoms
{
    [Serializable]
    public sealed class IntReference : ScriptableObjectReference<
        int,
        IntVariable>
    { }
}
