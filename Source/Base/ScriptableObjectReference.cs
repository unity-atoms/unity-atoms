namespace UnityAtoms
{
    public abstract class ScriptableObjectReference<T, V>
        where V : ScriptableObjectVariableBase<T>
    {
        public bool UseConstant;

        public T ConstantValue;

        public V Variable;

        protected ScriptableObjectReference()
        {
            UseConstant = true;
        }

        protected ScriptableObjectReference(T value) : this()
        {
            UseConstant = true;
            ConstantValue = value;
        }

        public T Value
        {
            get { return UseConstant ? ConstantValue : Variable.Value; }
        }

        public static implicit operator T(ScriptableObjectReference<T, V> reference)
        {
            return reference.Value;
        }
    }
}
