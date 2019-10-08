using UnityEngine;
using System;

namespace UnityAtoms
{
    [Serializable]
    public sealed class SceneFieldReference : AtomReference<
        SceneField,
        SceneFieldVariable>
    { }
}
