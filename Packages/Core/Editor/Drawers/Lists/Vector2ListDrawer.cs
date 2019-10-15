#if UNITY_2019_1_OR_NEWER
using UnityEditor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// List property drawer of type `Vector2`. Inherits from `AtomDrawer&lt;Vector2List&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(Vector2List))]
    public class Vector2ListDrawer : AtomDrawer<Vector2List> { }
}
#endif
