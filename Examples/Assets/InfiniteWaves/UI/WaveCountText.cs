using UnityEngine;
using UnityEngine.UI;

namespace UnityAtoms.Examples
{
    public class WaveCountText : MonoBehaviour
    {
        public void AdjustText(int waveCount) => GetComponent<Text>().text = $"Wave count: {waveCount}";
    }
}
