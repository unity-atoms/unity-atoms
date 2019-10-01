using System;
using UnityEngine;

namespace UnityAtoms
{
    [Serializable]
    public sealed class Collider2DReference : AtomReference<
        Collider2D,
        Collider2DVariable> { }
}
