namespace UnityAtoms.Editor
{

    internal struct AtomType
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
    }
}
