using UnityEngine;
using UnityEngine.Serialization;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/Molecules/Timer/Timer")]
    public class Timer : ScriptableObject
    {
        public bool Started { get { return _started; } }

        public float TimeElapsed;

        [FormerlySerializedAs("Started")]
        [SerializeField]
        private bool _started;

        public void Start()
        {
            _started = true;
        }

        public void Stop()
        {
            TimeElapsed = 0f;
            _started = false;
        }

        public float GetElapsedTime()
        {
            return TimeElapsed;
        }

        public bool IsStarted()
        {
            return _started;
        }
    }

}
