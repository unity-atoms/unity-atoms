using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Adds Variable Instancer's Variable of type Collider2D to a Collection or List on OnEnable and removes it on OnDestroy. 
    /// </summary>
    [AddComponentMenu("Unity Atoms/Sync Variable Instancer to Collection/Sync Collider2D Variable Instancer to Collection")]
    [EditorIcon("atom-icon-delicate")]
    public class SyncCollider2DVariableInstancerToCollection : SyncVariableInstancerToCollection<Collider2D, Collider2DVariable, Collider2DVariableInstancer> { }
}
