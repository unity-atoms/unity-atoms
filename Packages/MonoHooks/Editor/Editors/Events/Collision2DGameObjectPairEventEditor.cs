using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.MonoHooks.Editor
{
    /// <summary>
    /// Event property drawer of type `Collision2DGameObjectPair`. Inherits from `AtomEventEditor&lt;Collision2DGameObjectPair, Collision2DGameObjectPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(Collision2DGameObjectPairEvent))]
    public sealed class Collision2DGameObjectPairEventEditor : AtomEventEditor<Pair<Collision2DGameObject>> { }
}
