using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Adds Variable Instancer's Variable of type GameObject to a Collection or List on OnEnable and removes it on OnDestroy. 
    /// </summary>
    [AddComponentMenu("Unity Atoms/Sync Variable Instancer to Collection/Sync GameObject Variable Instancer to Collection")]
    [EditorIcon("atom-icon-delicate")]
    public class SyncGameObjectVariableInstancerToCollection : SyncVariableInstancerToCollection<GameObject, GameObjectVariable, GameObjectVariableInstancer> { }
}
