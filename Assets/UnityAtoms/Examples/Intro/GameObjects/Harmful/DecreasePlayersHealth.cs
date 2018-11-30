using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityAtoms.Examples
{
    [CreateAssetMenu(menuName = "Unity Atoms/Examples/Intro/Decrease Players Health")]
    public class DecreasePlayersHealth : Collider2DAction
    {
        [SerializeField]
        private StringConstant TagPlayer;

        public override void Do(Collider2D collider)
        {
            if (collider.gameObject.HasTag(TagPlayer))
            {
                collider.GetComponent<PlayerHealth>().Health.Value -= 10;
            }
        }
    }
}
