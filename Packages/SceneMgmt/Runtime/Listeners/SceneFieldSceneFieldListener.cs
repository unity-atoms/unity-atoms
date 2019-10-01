using UnityEngine;

namespace UnityAtoms.SceneMgmt
{
    [AddComponentMenu("Unity Atoms/Listeners/SceneField - SceneField")]
    public sealed class SceneFieldSceneFieldListener : AtomListener<
        SceneField,
        SceneField,
        SceneFieldSceneFieldAction,
        SceneFieldSceneFieldEvent,
        SceneFieldSceneFieldUnityEvent>
    { }
}
