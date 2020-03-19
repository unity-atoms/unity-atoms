using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Adds Variable Instancer's Variable of type Color to a Collection or List on OnEnable and removes it on OnDestroy. 
    /// </summary>
    [AddComponentMenu("Unity Atoms/Sync Variable Instancer to Collection/Sync Color Variable Instancer to Collection")]
    [EditorIcon("atom-icon-delicate")]
    public class SyncColorVariableInstancerToCollection : SyncVariableInstancerToCollection<Color, ColorVariable, ColorVariableInstancer> { }
}
