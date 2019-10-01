using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Base class for all atoms
    /// </summary>
    public abstract class BaseAtom : ScriptableObject
    {
        [SerializeField]
        [Multiline]
        private string _developerDescription;
    }
}
