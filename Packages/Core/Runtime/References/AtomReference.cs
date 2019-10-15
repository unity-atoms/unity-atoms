namespace UnityAtoms
{
    /// <summary>
    /// None generic base class for `AtomReference&lt;T, V&gt;`.
    /// </summary>
    public abstract class AtomReference { }

    public abstract class AtomReference<T, V> : AtomReference
        where V : AtomBaseVariable<T>
    {
        /// <summary>
        /// If set to `true` then use constant instead of Variable value.
        /// </summary>
        public bool UseConstant;

        /// <summary>
        /// Constant value used if `UseConstant` is set to `true`.
        /// </summary>
        public T ConstantValue;

        /// <summary>
        /// Variable used if `UseConstant` is set to `false`.
        /// </summary>
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

        /// <summary>
        /// Get the value for the Reference.
        /// </summary>
        /// <value>The value of type `T`.</value>
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
