using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Adds Variable Instancer's Variable of type Vector2 to a Collection or List on OnEnable and removes it on OnDestroy. 
    /// </summary>
    [AddComponentMenu("Unity Atoms/Sync Variable Instancer to Collection/Sync Vector2 Variable Instancer to Collection")]
    [EditorIcon("atom-icon-delicate")]
    public class SyncVector2VariableInstancerToCollection : SyncVariableInstancerToCollection<Vector2, Vector2Variable, Vector2VariableInstancer> { }
}
