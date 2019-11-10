using UnityEngine;
using UnityEngine.UI;

namespace UnityAtoms.Examples
{
    [AddComponentMenu("Unity Atoms/Examples/Int Text Setter")]
    public sealed class IntTextSetter : MonoBehaviour
    {
        [SerializeField]
        private Text _scoreText;
        [SerializeField]
        private IntReference score;
        [SerializeField]
        private StringReference _prefix;
        [SerializeField]
        private StringReference _suffix;

        public void UpdateText()
        {
            _scoreText.text = $"{_prefix.Value}{score.Value}{_suffix.Value}";
        }
    }
}
