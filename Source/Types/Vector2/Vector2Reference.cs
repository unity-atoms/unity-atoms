using System;
using UnityEngine;

namespace UnityAtoms
{
    [Serializable]
    public sealed class Vector2Reference : ScriptableObjectReference<
        Vector2,
        Vector2Variable,
        Vector2Event,
        Vector2Vector2Event>
    { }
}
