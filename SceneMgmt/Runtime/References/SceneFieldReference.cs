using UnityEngine;
using System;

namespace UnityAtoms.SceneMgmt
{
    [Serializable]
    public sealed class SceneFieldReference : AtomReference<
        SceneField,
        SceneFieldVariable>
    { }
}
