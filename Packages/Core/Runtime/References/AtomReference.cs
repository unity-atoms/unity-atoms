using System;
using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// A Reference lets you define a variable in your script where you then from the inspector can choose if it's going to be taking the value from a Constant, Variable, Value or a Variable Instancer.
    /// </summary>
    /// <typeparam name="T">The type of the variable.</typeparam>
    /// <typeparam name="C">Constant of type T.</typeparam>
    /// <typeparam name="V">Variable of type T.</typeparam>
    /// <typeparam name="E1">Event of type T.</typeparam>
    /// <typeparam name="E2">Event x 2 of type T.</typeparam>
    /// <typeparam name="F">Function of type T => T.</typeparam>
    /// <typeparam name="VI">Variable Instancer of type T.</typeparam>
    public abstract class AtomReference<T, C, V, E1, E2, F, VI> : AtomReferenceBase, IEquatable<AtomReference<T, C, V, E1, E2, F, VI>>
        where C : AtomBaseVariable<T>
        where V : AtomVariable<T, E1, E2, F>
        where E1 : AtomEvent<T>
        where E2 : AtomEvent<T, T>
        where F : AtomFunction<T, T>
        where VI : AtomVariableInstancer<V, T, E1, E2, F>
    {
        /// <summary>
        /// Get or set the value for the Reference.
        /// </summary>
        /// <value>The value of type `T`.</value>
        public T Value
        {
            get
            {
                switch (_usage)
                {
                    case (AtomReferenceBase.Usage.Constant): return _constant == null ? default(T) : _constant.Value;
                    case (AtomReferenceBase.Usage.Variable): return _variable == null ? default(T) : _variable.Value;
                    case (AtomReferenceBase.Usage.VariableInstancer): return _variableInstancer == null ? default(T) : _variableInstancer.Value;
                    case (AtomReferenceBase.Usage.Value):
                    default:
                        return _value;
                }
            }
            set
            {
                switch (_usage)
                {
                    case (AtomReferenceBase.Usage.Variable):
                        {
                            _variable.Value = value;
                            break;
                        }
                    case (AtomReferenceBase.Usage.Value):
                        {
                            _value = value;
                            break;
                        }
                    case (AtomReferenceBase.Usage.VariableInstancer):
                        {
                            _variableInstancer.Value = value;
                            break;
                        }
                    case (AtomReferenceBase.Usage.Constant):
                    default:
                        throw new NotSupportedException("Can't reassign constant value");
                }
            }
        }

        /// <summary>
        /// Value used if `Usage` is set to `Value`.
        /// </summary>
        [SerializeField]
        private T _value;

        /// <summary>
        /// Constant used if `Usage` is set to `Constant`.
        /// </summary>
        [SerializeField]
        private C _constant;

        /// <summary>
        /// Variable used if `Usage` is set to `Variable`.
        /// </summary>
        [SerializeField]
        private V _variable;

        /// <summary>
        /// Variable Instancer used if `Usage` is set to `VariableInstancer`.
        /// </summary>
        [SerializeField]
        private VI _variableInstancer;

        protected AtomReference()
        {
            _usage = AtomReferenceBase.Usage.Value;
        }

        protected AtomReference(T value) : this()
        {
            _usage = AtomReferenceBase.Usage.Value;
            _value = value;
        }

        public static implicit operator T(AtomReference<T, C, V, E1, E2, F, VI> reference)
        {
            return reference.Value;
        }

        protected abstract bool ValueEquals(T other);

        public bool Equals(AtomReference<T, C, V, E1, E2, F, VI> other)
        {
            if (other == null)
                return false;

            return ValueEquals(other.Value);
        }

        public override int GetHashCode()
        {
            return Value == null ? 0 : Value.GetHashCode();
        }
    }
}
