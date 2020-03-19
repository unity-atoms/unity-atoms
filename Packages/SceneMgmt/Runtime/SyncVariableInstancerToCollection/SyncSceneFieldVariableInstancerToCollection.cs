using UnityEngine;
using UnityAtoms.BaseAtoms;
using UnityAtoms.SceneMgmt;

namespace UnityAtoms.SceneMgmt
{
    /// <summary>
    /// Adds Variable Instancer's Variable of type SceneField to a Collection or List on OnEnable and removes it on OnDestroy. 
    /// </summary>
    [AddComponentMenu("Unity Atoms/Sync Variable Instancer to Collection/Sync SceneField Variable Instancer to Collection")]
    [EditorIcon("atom-icon-delicate")]
    public class SyncSceneFieldVariableInstancerToCollection : SyncVariableInstancerToCollection<SceneField, SceneFieldVariable, SceneFieldVariableInstancer> { }
}
