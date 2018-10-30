namespace UnityAtoms
{
    public abstract class ScriptableObjectReference<T, V, E1, E2> where E1 : GameEvent<T> where E2 : GameEvent<T, T> where V : ScriptableObjectVariable<T, E1, E2>
    {
        public bool UseConstant = true;
        public T ConstantValue;
        public V Variable;

        public ScriptableObjectReference() { }

        public ScriptableObjectReference(T value)
        {
            UseConstant = true;
            ConstantValue = value;
        }

        public T Value
        {
            get { return UseConstant ? ConstantValue : Variable.Value; }
        }

        public static implicit operator T(ScriptableObjectReference<T, V, E1, E2> reference)
        {
            return reference.Value;
        }
    }
}