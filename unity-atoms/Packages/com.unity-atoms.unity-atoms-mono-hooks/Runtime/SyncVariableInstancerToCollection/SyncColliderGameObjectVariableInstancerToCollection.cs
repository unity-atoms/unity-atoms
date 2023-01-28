using UnityEngine;
using UnityAtoms.BaseAtoms;
using UnityAtoms.MonoHooks;

namespace UnityAtoms.MonoHooks
{
    /// <summary>
    /// Adds Variable Instancer's Variable of type ColliderGameObject to a Collection or List on OnEnable and removes it on OnDestroy. 
    /// </summary>
    [AddComponentMenu("Unity Atoms/Sync Variable Instancer to Collection/Sync ColliderGameObject Variable Instancer to Collection")]
    [EditorIcon("atom-icon-delicate")]
    public class SyncColliderGameObjectVariableInstancerToCollection : SyncVariableInstancerToCollection<ColliderGameObject, ColliderGameObjectVariable, ColliderGameObjectVariableInstancer> { }
}
