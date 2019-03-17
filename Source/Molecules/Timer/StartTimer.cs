using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/Molecules/Timer/Start Timer")]
    public class StartTimer : VoidAction
    {
        [SerializeField]
        private Timer Timer = null;

        public override void Do()
        {
            Timer.Start();
        }
    }
}
