using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UnityAtoms
{
	[CreateAssetMenu(menuName = "Unity Atoms/Game Actions/Change Scene")]
	public class ChangeScene : VoidAction
	{
		[SerializeField]
		private string SceneName = null;

		public override void Do()
		{
			SceneManager.LoadScene(SceneName);
		}
	}

}

