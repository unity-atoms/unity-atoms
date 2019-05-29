using UnityEngine;
using System;

namespace UnityAtoms
{
    [Serializable]
    public sealed class SceneFieldReference : ScriptableObjectReference<
        SceneField,
        SceneFieldVariable>
    { }
}
