using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Adds Variable Instancer's Variable of type Collision2D to a Collection or List on OnEnable and removes it on OnDestroy. 
    /// </summary>
    [AddComponentMenu("Unity Atoms/Sync Variable Instancer to Collection/Sync Collision2D Variable Instancer to Collection")]
    [EditorIcon("atom-icon-delicate")]
    public class SyncCollision2DVariableInstancerToCollection : SyncVariableInstancerToCollection<Collision2D, Collision2DVariable, Collision2DVariableInstancer> { }
}
