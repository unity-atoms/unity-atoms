using System;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Internal module class that holds that regarding an Atom type.
    /// </summary>

    internal struct AtomReceipe : IEquatable<AtomReceipe>
    {
        public AtomType AtomType { get; set; }
        public string ValueType { get; set; }

        public AtomReceipe(AtomType atomType, string valueType)
        {
            this.AtomType = atomType;
            this.ValueType = valueType;
        }

        public bool Equals(AtomReceipe other)
        {
            return this.AtomType.Equals(other) && this.ValueType == other.ValueType;
        }

        public override bool Equals(object obj)
        {
            return Equals((AtomReceipe)obj);
        }

        public override int GetHashCode()
        {
            var hash = 17;
            hash = hash * 23 + this.AtomType.GetHashCode();
            hash = hash * 23 + this.ValueType.GetHashCode();
            return hash;
        }

        public void Deconstruct(out AtomType atomType, out string valueType)
        {
            atomType = this.AtomType;
            valueType = this.ValueType;
        }
    }
}
