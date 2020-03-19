using UnityEngine;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Adds Variable Instancer's Collection to a Collection or List on OnEnable and removes it on OnDestroy. 
    /// </summary>
    [AddComponentMenu("Unity Atoms/Collections/Sync Collection Instancer to Collection")]
    [EditorIcon("atom-icon-delicate")]
    public class SyncCollectionInstancerToCollection : SyncVariableInstancerToCollection<StringReferenceAtomBaseVariableDictionary, AtomCollection, AtomCollectionInstancer> { }
}
