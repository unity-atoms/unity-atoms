using UnityEngine;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Adds Variable Instancer's List to a Collection or List on OnEnable and removes it on OnDestroy. 
    /// </summary>
    [AddComponentMenu("Unity Atoms/Collections/Sync List Instancer to Collection")]
    [EditorIcon("atom-icon-delicate")]
    public class SyncListInstancerToCollection : SyncVariableInstancerToCollection<AtomBaseVariableList, AtomList, AtomListInstancer> { }
}
