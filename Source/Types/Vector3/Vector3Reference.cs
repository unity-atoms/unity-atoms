using System;
using UnityEngine;

namespace UnityAtoms
{
    [Serializable]
    public sealed class Vector3Reference : ScriptableObjectReference<
        Vector3,
        Vector3Variable,
        Vector3Event,
        Vector3Vector3Event>
    { }
}
