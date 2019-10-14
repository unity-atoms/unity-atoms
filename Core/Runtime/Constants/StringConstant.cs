using UnityEngine;

namespace UnityAtoms
{
    [EditorIcon("atom-icon-teal")]
    [CreateAssetMenu(menuName = "Unity Atoms/Constants/String", fileName = "StringConstant")]
    public sealed class StringConstant : AtomBaseVariable<string> { }
}
