using System;
using UnityEngine;

namespace UnityAtoms
{
    [Serializable]
    public sealed class GameObjectReference : AtomReference<
        GameObject,
        GameObjectVariable>
    { }
}
