using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/Molecules/Timer/Stop Timer")]
    public class StopTimer : VoidAction
    {
        [SerializeField]
        private Timer Timer;

        public override void Do()
        {
            Timer.Stop();
        }
    }
}
