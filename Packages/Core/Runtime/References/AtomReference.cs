namespace UnityAtoms
{
    public abstract class AtomReference { }

    public abstract class AtomReference<T, V> : AtomReference
        where V : AtomBaseVariable<T>
    {
        public bool UseConstant;

        public T ConstantValue;

        public V Variable;

        protected AtomReference()
        {
            UseConstant = true;
        }

        protected AtomReference(T value) : this()
        {
            UseConstant = true;
            ConstantValue = value;
        }

        public T Value
        {
            get { return UseConstant ? ConstantValue : Variable.Value; }
        }

        public static implicit operator T(AtomReference<T, V> reference)
        {
            return reference.Value;
        }
    }
}
