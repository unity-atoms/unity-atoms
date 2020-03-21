using UnityEngine;
using UnityEngine.UI;

namespace UnityAtoms.Examples
{
    /// <summary>
    /// Sets the text for the Wave count UI.
    /// </summary>
    public class WaveCountText : MonoBehaviour
    {
        public void AdjustText(int waveCount) => GetComponent<Text>().text = $"Wave count: {waveCount}";
    }
}
