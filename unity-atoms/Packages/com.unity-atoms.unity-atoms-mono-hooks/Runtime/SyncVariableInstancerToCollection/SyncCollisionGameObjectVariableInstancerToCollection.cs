using UnityEngine;
using UnityAtoms.BaseAtoms;
using UnityAtoms.MonoHooks;

namespace UnityAtoms.MonoHooks
{
    /// <summary>
    /// Adds Variable Instancer's Variable of type CollisionGameObject to a Collection or List on OnEnable and removes it on OnDestroy. 
    /// </summary>
    [AddComponentMenu("Unity Atoms/Sync Variable Instancer to Collection/Sync CollisionGameObject Variable Instancer to Collection")]
    [EditorIcon("atom-icon-delicate")]
    public class SyncCollisionGameObjectVariableInstancerToCollection : SyncVariableInstancerToCollection<CollisionGameObject, CollisionGameObjectVariable, CollisionGameObjectVariableInstancer> { }
}
