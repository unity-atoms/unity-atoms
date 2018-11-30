using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/Molecules/Timer/Timer")]
    public class Timer : ScriptableObject
    {
        public float TimeElapsed = 0f;
        public bool Started = false;

        public void Start()
        {
            Started = true;
        }

        public void Stop()
        {
            TimeElapsed = 0f;
            Started = false;
        }

        public float GetElapsedTime()
        {
            return TimeElapsed;
        }

        public bool IsStarted()
        {
            return Started;
        }
    }

}