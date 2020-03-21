using UnityEngine;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms.Examples
{
    /// <summary>
    /// An IntAction that Debug.Logs the value it recieves.
    /// </summary>
    [CreateAssetMenu(menuName = "Unity Atoms/Examples/Intro/Health Logger")]
    public sealed class HealthLogger : IntAction
    {
        public override void Do(int health)
        {
            Debug.Log("<3: " + health);
        }
    }
}
