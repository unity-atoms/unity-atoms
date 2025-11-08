using UnityEngine;
using UnityAtoms.BaseAtoms;
using UnityAtoms.MonoHooks;

namespace UnityAtoms.MonoHooks
{
    /// <summary>
    /// Adds Variable Instancer's Variable of type Collider2DGameObject to a Collection or List on OnEnable and removes it on OnDestroy. 
    /// </summary>
    [AddComponentMenu("Unity Atoms/Sync Variable Instancer to Collection/Sync Collider2DGameObject Variable Instancer to Collection")]
    [EditorIcon("atom-icon-delicate")]
    public class SyncCollider2DGameObjectVariableInstancerToCollection : SyncVariableInstancerToCollection<Collider2DGameObject, Collider2DGameObjectVariable, Collider2DGameObjectVariableInstancer> { }
}
