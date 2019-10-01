using System;
using UnityEngine;

namespace UnityAtoms
{
    [Serializable]
    public sealed class ColliderReference : AtomReference<
        Collider,
        ColliderVariable> { }
}
