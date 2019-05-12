using UnityEngine;
using UnityAtoms.Tags;
using UnityEngine.Serialization;

namespace UnityAtoms.Examples
{
    [CreateAssetMenu(menuName = "Unity Atoms/Examples/Intro/Decrease Players Health")]
    public sealed class DecreasePlayersHealth : Collider2DAction
    {
        [FormerlySerializedAs("TagPlayer")]
        [SerializeField]
        private StringConstant _tagPlayer = null;

        public override void Do(Collider2D collider)
        {
            if (collider.gameObject.HasTag(_tagPlayer))
            {
                collider.GetComponent<PlayerHealth>().Health.Value -= 10;
            }
        }
    }
}
