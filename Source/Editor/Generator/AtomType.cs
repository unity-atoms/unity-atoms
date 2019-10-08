using System;

namespace UnityAtoms.Editor
{

    internal struct AtomType : IEquatable<AtomType>
    {
        public string Type;
        public string DisplayName;
        public int TypeOccurences;

        public AtomType(string type, string displayName = null, int typeOccurences = 1)
        {
            this.Type = type;
            this.DisplayName = displayName == null ? type : displayName;
            this.TypeOccurences = typeOccurences;
        }

        public bool Equals(AtomType other)
        {
            return this.Type == other.Type && this.TypeOccurences == other.TypeOccurences;
        }

        public override bool Equals(object obj)
        {
            return Equals((AtomType)obj);
        }

        public override int GetHashCode()
        {
            var hash = 17;
            hash = hash * 23 + this.Type.GetHashCode();
            hash = hash * 23 + this.TypeOccurences.GetHashCode();
            return hash;
        }
    }
}
