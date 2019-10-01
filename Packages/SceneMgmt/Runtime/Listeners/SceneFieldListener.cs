using UnityEngine;

namespace UnityAtoms.SceneMgmt
{
    [AddComponentMenu("Unity Atoms/Listeners/SceneField")]
    public sealed class SceneFieldListener : AtomListener<
        SceneField,
        SceneFieldAction,
        SceneFieldEvent,
        SceneFieldUnityEvent>
    { }
}
