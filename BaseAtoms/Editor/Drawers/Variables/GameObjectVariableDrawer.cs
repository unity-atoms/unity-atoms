#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Variable property drawer of type `GameObject`. Inherits from `AtomDrawer&lt;GameObjectVariable&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(GameObjectVariable))]
    public class GameObjectVariableDrawer : VariableDrawer<GameObjectVariable> { }
}
#endif
