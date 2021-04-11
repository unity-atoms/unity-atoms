using UnityEditor;
using UnityAtoms.Editor;
using UnityEngine;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `QuaternionPair`. Inherits from `AtomEventEditor&lt;QuaternionPair, QuaternionPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(QuaternionPairEvent))]
    public sealed class QuaternionPairEventEditor : AtomEventEditor<Pair<Quaternion>> { }
}
