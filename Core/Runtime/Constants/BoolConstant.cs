using UnityEngine;

namespace UnityAtoms
{
    [EditorIcon("atom-icon-teal")]
    [CreateAssetMenu(menuName = "Unity Atoms/Constants/Bool", fileName = "BoolConstant")]
    public sealed class BoolConstant : AtomBaseVariable<bool> { }
}
