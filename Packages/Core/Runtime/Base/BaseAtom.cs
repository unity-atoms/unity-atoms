using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// None generic base class for all Atoms.
    /// </summary>
    [AtomsSearchable]
    public abstract class BaseAtom : ScriptableObject
    {
        /// <summary>
        /// A description of the Atom made for documentation purposes.
        /// </summary>
        [SerializeField]
        [TextArea(3, 6)]
        private string _developerDescription;
    }
}
