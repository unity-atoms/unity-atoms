#if PACKAGE_UNITY_PHYSICS
using UnityEngine;
namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Action of type `ColliderPair`. Inherits from `AtomAction&lt;ColliderPair&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-purple")]
    public abstract class ColliderPairAction : AtomAction<ColliderPair> { }
}
#endif
