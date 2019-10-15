#if UNITY_2019_1_OR_NEWER
using UnityEditor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event x 2 property drawer of type `Vector2`. Inherits from `AtomDrawer&lt;Vector2Vector2Event&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(Vector2Vector2Event))]
    public class Vector2Vector2EventDrawer : AtomDrawer<Vector2Vector2Event> { }
}
#endif
