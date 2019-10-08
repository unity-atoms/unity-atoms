#if UNITY_2019_1_OR_NEWER
using UnityEditor;

namespace UnityAtoms.Editor
{
    [CustomPropertyDrawer(typeof(GameObjectConstant))]
    public class GameObjectConstantDrawer : AtomDrawer<GameObjectConstant> { }
}
#endif
