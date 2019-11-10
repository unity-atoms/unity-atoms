using UnityEngine;

namespace UnityAtoms.Examples
{
    [AddComponentMenu("Unity Atoms/Examples/Score Audio Player")]
    public sealed class ScoreAudioPlayer : MonoBehaviour
    {
        [SerializeField]
        private AudioSource _audioSource;
        [SerializeField]
        public AudioClip _normalSound;
        [SerializeField]
        public AudioClip _bigScoreSound;

        public void ScoreUpdated(int currentValue, int oldValue)
        {
            if (currentValue <= 0) return;

            _audioSource.clip = currentValue > oldValue + 5 ? _bigScoreSound : _normalSound;
            _audioSource.Play();
        }
    }
}
