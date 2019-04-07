using UnityEngine;
using UnityEngine.Serialization;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/Molecules/Timer/Start Timer")]
    public sealed class StartTimer : VoidAction
    {
        [FormerlySerializedAs("Timer")]
        [SerializeField]
        private Timer _timer;

        public override void Do()
        {
            _timer.Start();
        }
    }
}
