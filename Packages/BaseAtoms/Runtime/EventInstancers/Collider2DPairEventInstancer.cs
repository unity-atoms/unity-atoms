using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Instancer of type `Collider2DPair`. Inherits from `AtomEventInstancer&lt;Pair&lt;Collider2D&gt;&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/Collider2DPair Event Instancer")]
    public class Collider2DPairEventInstancer : AtomEventInstancer<Pair<Collider2D>> { }
}
