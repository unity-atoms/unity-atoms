using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// None generic base class for all Listeners.
    /// </summary>
    public abstract class AtomBaseListener : MonoBehaviour
    {
        /// <summary>
        /// A description of the Listener made for documentation purposes.
        /// </summary>
        [SerializeField]
        [Multiline]
        private string _developerDescription;
    }
}
