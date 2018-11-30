using UnityEngine;

namespace UnityAtoms
{
    /* Updates the Timer. Meant to be placed on a OnUpdateMonoHook.
    */
    [CreateAssetMenu(menuName = "Unity Atoms/Molecules/Timer/Update Timer")]
    public class UpdateTimer : VoidAction
    {
        [SerializeField]
        private Timer Timer;

        public override void Do()
        {
            if (Timer.Started)
            {
                Timer.TimeElapsed += Time.deltaTime;
            }
        }
    }
}
