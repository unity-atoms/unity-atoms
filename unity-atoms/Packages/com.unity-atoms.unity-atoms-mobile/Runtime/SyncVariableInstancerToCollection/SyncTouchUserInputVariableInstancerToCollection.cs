using UnityEngine;
using UnityAtoms.BaseAtoms;
using UnityAtoms.Mobile;

namespace UnityAtoms.Mobile
{
    /// <summary>
    /// Adds Variable Instancer's Variable of type TouchUserInput to a Collection or List on OnEnable and removes it on OnDestroy. 
    /// </summary>
    [AddComponentMenu("Unity Atoms/Sync Variable Instancer to Collection/Sync TouchUserInput Variable Instancer to Collection")]
    [EditorIcon("atom-icon-delicate")]
    public class SyncTouchUserInputVariableInstancerToCollection : SyncVariableInstancerToCollection<TouchUserInput, TouchUserInputVariable, TouchUserInputVariableInstancer> { }
}
