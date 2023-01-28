using System;

namespace UnityAtoms
{
    /// <summary>
    /// Attribute that makes an Atom searchable.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, Inherited = true, AllowMultiple = false)]
    public class AtomsSearchable : Attribute { }
}
