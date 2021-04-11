using UnityEngine;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms.MonoHooks
{
    /// <summary>
    /// Adds Variable Instancer's Variable of type Collision2DGameObject to a Collection or List on OnEnable and removes it on OnDestroy. 
    /// </summary>
    [AddComponentMenu("Unity Atoms/Sync Variable Instancer to Collection/Sync Collision2DGameObject Variable Instancer to Collection")]
    [EditorIcon("atom-icon-delicate")]
    public class SyncCollision2DGameObjectVariableInstancerToCollection : SyncVariableInstancerToCollection<Collision2DGameObject> { }
}
