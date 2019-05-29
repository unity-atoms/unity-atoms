using UnityEngine;
using UnityAtoms.Extensions;
using UnityAtoms.Utils;
using UnityEngine.Assertions;
using UnityEngine.Serialization;

namespace UnityAtoms
{
    /* Gets an unused GameObject from the GameObjectList. If an GameObject is used or not is determined by IsUsed GameFunction.
	 * If no unused GameObject is found a new one is instantiated and added to the GameObjectList.
	 */
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Get Unused GameObject (GameObject - (V3, Quat))")]
    public sealed class GetUnusedGameObject : GameObjectVector3QuaternionFunction
    {
        [FormerlySerializedAs("List")]
        [SerializeField]
        private GameObjectList _list = null;

        [FormerlySerializedAs("Prefab")]
        [SerializeField]
        private GameObject _prefab = null;

        [FormerlySerializedAs("IsNotUsed")]
        [SerializeField]
        private BoolGameObjectFunction _isNotUsed = null;

        public override GameObject Call(Vector3 position, Quaternion quaternion)
        {
            Assert.IsNotNull(_list, RuntimeConstants.LOG_PREFIX + "List must be assigned in the inspector when using GetUnusedGameObject");
            Assert.IsNotNull(_prefab, RuntimeConstants.LOG_PREFIX + "Prefab must be assigned in the inspector when using GetUnusedGameObject");
            Assert.IsNotNull(_isNotUsed, RuntimeConstants.LOG_PREFIX + "IsUsed must be assigned in the inspector when using GetUnusedGameObject");

            return _list.List.GetOrInstantiate(_prefab, position, quaternion, _isNotUsed.Call);
        }
    }
}
