using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Instancer of type `GameObjectPair`. Inherits from `AtomEventInstancer&lt;GameObjectPair, GameObjectPairEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/GameObjectPair Event Instancer")]
    public class GameObjectPairEventInstancer : AtomEventInstancer<GameObjectPair, GameObjectPairEvent> { }
}
