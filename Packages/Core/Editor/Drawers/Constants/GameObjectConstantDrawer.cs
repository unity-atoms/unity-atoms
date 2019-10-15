#if UNITY_2019_1_OR_NEWER
using UnityEditor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Constant property drawer of type `GameObject`. Inherits from `AtomDrawer&lt;GameObjectConstant&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(GameObjectConstant))]
    public class GameObjectConstantDrawer : AtomDrawer<GameObjectConstant> { }
}
#endif
