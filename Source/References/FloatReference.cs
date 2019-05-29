using System;

namespace UnityAtoms
{
    [Serializable]
    public sealed class FloatReference : ScriptableObjectReference<
        float,
        FloatVariable>
    { }
}
