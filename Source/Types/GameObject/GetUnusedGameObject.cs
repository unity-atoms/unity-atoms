using UnityEngine;
using UnityAtoms.Extensions;
using UnityEngine.Serialization;
#if UNITY_EDITOR
using UnityAtoms.Logger;
#endif

namespace UnityAtoms
{
    /* Gets an unused GameObject from the GameObjectList. If an GameObject is used or not is determined by IsUsed GameFunction.
	 * If no unused GameObject is found a new one is instantiated and added to the GameObjectList.
	 */
    [CreateAssetMenu(menuName = "Unity Atoms/GameObject/Get Unused GameObject (GameObject - (V3, Quat))", fileName = "GetUnusedGameObject")]
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
            if (_isNotUsed == null)
            {
#if UNITY_EDITOR
                AtomsLogger.Warning("IsUsed must be defined when using GetUnusedGameObject");
#endif
            }

            return _list.List.GetOrInstantiate(_prefab, position, quaternion, _isNotUsed.Call);
        }
    }
}
