using UnityEngine;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms.Examples
{
    /// <summary>
    /// A component that contains the Player's health.
    /// </summary>
    public class UnitHealth : MonoBehaviour
    {
        public int Health { get => _health.Value; set => _health.Value = value; }


        [SerializeField]
        private IntReference _health;
    }
}