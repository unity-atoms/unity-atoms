using System;
using UnityEngine;

namespace UnityAtoms
{
    [Serializable]
    public sealed class Vector3Reference : AtomReference<
        Vector3,
        Vector3Variable>
    { }
}
