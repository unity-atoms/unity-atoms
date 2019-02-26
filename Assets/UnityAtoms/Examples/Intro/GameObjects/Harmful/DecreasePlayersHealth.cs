using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityAtoms.Examples
{
	[CreateAssetMenu(menuName = "Unity Atoms/Examples/Intro/Game Actions/Decrease Players Health")]
	public class DecreasePlayersHealth : Collider2DAction
	{
		[SerializeField]
		private StringConstant TagPlayer = null;

		public override void Do(Collider2D collider)
		{
			if (collider.tag == TagPlayer.Value)
			{
				collider.GetComponent<PlayerHealth>().Health.Value -= 10;
			}
		}
	}
}
