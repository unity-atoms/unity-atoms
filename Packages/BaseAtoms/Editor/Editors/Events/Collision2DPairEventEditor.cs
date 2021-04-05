using UnityAtoms.Editor;
using UnityEditor;
using UnityEngine;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `Collision2DPair`. Inherits from `AtomEventEditor&lt;Collision2DPair, Collision2DPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(Collision2DPairEvent))]
    public sealed class Collision2DPairEventEditor : AtomEventEditor<Pair<Collision2D>> { }
}
