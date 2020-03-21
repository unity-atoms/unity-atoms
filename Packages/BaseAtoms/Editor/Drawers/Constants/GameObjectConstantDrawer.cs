#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Constant property drawer of type `GameObject`. Inherits from `AtomDrawer&lt;GameObjectConstant&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(GameObjectConstant))]
    public class GameObjectConstantDrawer : VariableDrawer<GameObjectConstant> { }
}
#endif
