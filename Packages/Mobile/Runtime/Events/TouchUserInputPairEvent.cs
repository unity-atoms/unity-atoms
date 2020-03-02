using UnityEngine;
using UnityAtoms.Mobile;

namespace UnityAtoms.Mobile
{
    /// <summary>
    /// Event of type `TouchUserInputPair`. Inherits from `AtomEvent&lt;TouchUserInputPair&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/TouchUserInputPair", fileName = "TouchUserInputPairEvent")]
    public sealed class TouchUserInputPairEvent : AtomEvent<TouchUserInputPair> { }
}
