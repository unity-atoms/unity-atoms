using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// None generic base class for all atoms.
    /// </summary>
    public abstract class BaseAtom : ScriptableObject
    {
        /// <summary>
        /// A description of the Atom made for developers to document their Atoms.
        /// </summary>
        [SerializeField]
        [Multiline]
        private string _developerDescription;
    }
}
