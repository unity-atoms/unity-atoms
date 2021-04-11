using System;
using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// A Reference lets you define a variable in your script where you then from the inspector can choose if it's going to be taking the value from a Constant, Variable, Value or a Variable Instancer.
    /// </summary>
    /// <typeparam name="T">The type of the variable.</typeparam>
    [Serializable]
    public class AtomReference<T> : AtomBaseReference, IEquatable<AtomReference<T>>, IGetEvent, ISetEvent
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
                    case (AtomReferenceUsage.CONSTANT): return _constant == null ? default(T) : _constant.Value;
                    case (AtomReferenceUsage.VARIABLE): return _variable == null ? default(T) : _variable.Value;
                    case (AtomReferenceUsage.VARIABLE_INSTANCER): return _variableInstancer == null || _variableInstancer.Variable == null ? default(T) : _variableInstancer.Value;
                    case (AtomReferenceUsage.VALUE):
                    default:
                        return _value;
                }
            }
            set
            {
                switch (_usage)
                {
                    case (AtomReferenceUsage.VARIABLE):
                        {
                            _variable.Value = value;
                            break;
                        }
                    case (AtomReferenceUsage.VALUE):
                        {
                            _value = value;
                            break;
                        }
                    case (AtomReferenceUsage.VARIABLE_INSTANCER):
                        {
                            _variableInstancer.Value = value;
                            break;
                        }
                    case (AtomReferenceUsage.CONSTANT):
                    default:
                        throw new NotSupportedException("Can't reassign constant value.");
                }
            }
        }

        /// <returns>True if the `Usage` is an AtomType and is unassigned. False otherwise.</returns>
        public bool IsUnassigned
        {
            get
            {
                switch (_usage)
                {
                    case (AtomReferenceUsage.CONSTANT): return _constant == null;
                    case (AtomReferenceUsage.VARIABLE): return _variable == null;
                    case (AtomReferenceUsage.VARIABLE_INSTANCER): return _variableInstancer == null || _variableInstancer.Variable == null;
                }
                return false;
            }
        }

        /// <summary>
        /// Value used if `Usage` is set to `Value`.
        /// </summary>
        [SerializeField]
        private T _value = default(T);

        /// <summary>
        /// Constant used if `Usage` is set to `Constant`.
        /// </summary>
        [SerializeField]
        private AtomBaseVariable<T> _constant = default(AtomBaseVariable<T>);

        /// <summary>
        /// Variable used if `Usage` is set to `Variable`.
        /// </summary>
        [SerializeField]
        private AtomVariable<T> _variable = default(AtomVariable<T>);

        /// <summary>
        /// Variable Instancer used if `Usage` is set to `VariableInstancer`.
        /// </summary>
        [SerializeField]
        private AtomVariableInstancer<T> _variableInstancer = default(AtomVariableInstancer<T>);

        public AtomReference()
        {
            _usage = AtomReferenceUsage.VALUE;
        }

        public AtomReference(T value) : this()
        {
            _usage = AtomReferenceUsage.VALUE;
            _value = value;
        }

        public static implicit operator T(AtomReference<T> reference)
        {
            return reference.Value;
        }

        public bool Equals(AtomReference<T> other)
        {
            if (other == null)
                return false;

            return ValueEquals(other.Value);
        }

        public override int GetHashCode()
        {
            return Value == null ? 0 : Value.GetHashCode();
        }

        /// <summary>
        /// Get event by type.
        /// </summary>
        /// <typeparam name="E"></typeparam>
        /// <returns>The event.</returns>
        public E GetEvent<E>() where E : AtomEventBase
        {
            switch (_usage)
            {
                case (AtomReferenceUsage.VARIABLE):
                    {
                        return _variable.GetEvent<E>();
                    }
                case (AtomReferenceUsage.VARIABLE_INSTANCER):
                    {
                        return _variableInstancer.GetEvent<E>();
                    }
                case (AtomReferenceUsage.VALUE):
                case (AtomReferenceUsage.CONSTANT):
                default:
                    throw new Exception($"Can't retrieve Event when usages is set to '{AtomReferenceUsage.DisplayName(_usage)}'! Usage needs to be set to '{AtomReferenceUsage.DisplayName(AtomReferenceUsage.VARIABLE)}' or '{AtomReferenceUsage.DisplayName(AtomReferenceUsage.VARIABLE_INSTANCER)}'.");
            }
        }

        /// <summary>
        /// Set event by type.
        /// </summary>
        /// <param name="e">The new event value.</param>
        /// <typeparam name="E"></typeparam>
        public void SetEvent<E>(E e) where E : AtomEventBase
        {
            switch (_usage)
            {
                case (AtomReferenceUsage.VARIABLE):
                    {
                        _variable.SetEvent<E>(e);
                        return;
                    }
                case (AtomReferenceUsage.VARIABLE_INSTANCER):
                    {
                        _variableInstancer.SetEvent<E>(e);
                        return;
                    }
                case (AtomReferenceUsage.VALUE):
                case (AtomReferenceUsage.CONSTANT):
                default:
                    throw new Exception($"Can't set Event when usages is set to '{AtomReferenceUsage.DisplayName(_usage)}'! Usage needs to be set to '{AtomReferenceUsage.DisplayName(AtomReferenceUsage.VARIABLE)}' or '{AtomReferenceUsage.DisplayName(AtomReferenceUsage.VARIABLE_INSTANCER)}'.");
            }
        }

        private bool ValueEquals(T other)
        {
            return (Value == null && other == null) || (Value != null && Value.Equals(other));
        }
    }
}
