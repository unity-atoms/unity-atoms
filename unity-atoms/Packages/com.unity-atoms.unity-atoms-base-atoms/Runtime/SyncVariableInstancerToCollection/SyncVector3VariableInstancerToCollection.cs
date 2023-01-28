using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Adds Variable Instancer's Variable of type Vector3 to a Collection or List on OnEnable and removes it on OnDestroy. 
    /// </summary>
    [AddComponentMenu("Unity Atoms/Sync Variable Instancer to Collection/Sync Vector3 Variable Instancer to Collection")]
    [EditorIcon("atom-icon-delicate")]
    public class SyncVector3VariableInstancerToCollection : SyncVariableInstancerToCollection<Vector3, Vector3Variable, Vector3VariableInstancer> { }
}
