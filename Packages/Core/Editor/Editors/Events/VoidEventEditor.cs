#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;

namespace UnityAtoms.Editor
{
    [CustomEditor(typeof(VoidEvent))]
    public sealed class VoidEventEditor : AtomEventEditor<Void, VoidEvent> { }
}
#endif
