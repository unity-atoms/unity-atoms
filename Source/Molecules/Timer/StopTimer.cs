using UnityEngine;
using UnityEngine.Serialization;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/Molecules/Timer/Stop Timer")]
    public sealed class StopTimer : VoidAction
    {
        [FormerlySerializedAs("Timer")]
        [SerializeField]
        private Timer _timer;

        public override void Do()
        {
            _timer.Stop();
        }
    }
}
