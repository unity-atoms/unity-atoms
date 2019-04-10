using UnityEngine;
using UnityEngine.Serialization;

namespace UnityAtoms
{
    /// <summary>
    /// Updates the Timer. Meant to be placed on a OnUpdateMonoHook.
    /// </summary>
    [CreateAssetMenu(menuName = "Unity Atoms/Molecules/Timer/Update Timer")]
    public sealed class UpdateTimer : VoidAction
    {
        [FormerlySerializedAs("Timer")]
        [SerializeField]
        private Timer _timer = null;

        public override void Do()
        {
            if (_timer.Started)
            {
                _timer.TimeElapsed += Time.deltaTime;
            }
        }
    }
}
