using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityAtoms
{
	/* Gets an unused GameObject from the GameObjectList. If an GameObject is used or not is determined by IsUsed GameFunction.
	 * If no unused GameObject is found a new one is instantiated and added to the GameObjectList.
	 */
	[CreateAssetMenu(menuName = "Unity Atoms/Game Functions/Get Unused GameObject")]
	public class GetUnusedGameObject : GameObjectVector3QuaternionFunction
	{
		[SerializeField]
		private GameObjectList List = null;

		[SerializeField]
		private GameObject Prefab = null;

		[SerializeField]
		private BoolGameObjectFunction IsUsed = null;

		public override GameObject Call(Vector3 position, Quaternion quaternion)
		{
			if (IsUsed == null)
			{
				Debug.LogWarning("IsUsed must be defined!");
			}

			for (int i = 0; i < List.Count; ++i)
			{
				if (!IsUsed.Call(List[i]))
				{
					List[i].transform.position = position;
					List[i].transform.rotation = quaternion;
					return List[i];
				}
			}

			var newGameObject = Instantiate(Prefab, position, quaternion);
			List.Add(newGameObject);
			return newGameObject;
		}
	}
}