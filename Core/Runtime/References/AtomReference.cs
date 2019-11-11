using System;
using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// None generic base class for `AtomReference&lt;T, V&gt;`.
    /// </summary>
    public abstract class AtomReference
    {
        /// <summary>
        /// Enum for how to use the Reference.
        /// </summary>
        public enum Usage
        {
            Value = 0,
            Constant = 1,
            Variable = 2,
        }

        /// <summary>
        /// Should we use the provided value (via inspector), the Constant value or the Variable value?
        /// </summary>
        [SerializeField]
        protected Usage _usage;
    }

    public abstract class AtomReference<T, V, C> : AtomReference
        where V : AtomBaseVariable<T>
        where C : AtomBaseVariable<T>
    {
        /// <summary>
        /// Value used if `Usage` is set to `Value`.
        /// </summary>
        [SerializeField]
        private T _value;

        /// <summary>
        /// Constant used if `Usage` is set to `Constant`.
        /// </summary>
        public C _constant;

        /// <summary>
        /// Variable used if `Usage` is set to `Variable`.
        /// </summary>
        public V _variable;

        protected AtomReference()
        {
            _usage = AtomReference.Usage.Value;
        }

        protected AtomReference(T value) : this()
        {
            _usage = AtomReference.Usage.Value;
            _value = value;
        }

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
                    case (AtomReference.Usage.Constant): return _constant.Value;
                    case (AtomReference.Usage.Variable): return _variable.Value;
                    case (AtomReference.Usage.Value):
                    default:
                        return _value;
                }
            }
            set
            {
                switch (_usage)
                {
                    case (AtomReference.Usage.Variable):
                    {
                        _variable.Value = value;
                        break;
                    }
                    case (AtomReference.Usage.Value):
                    {
                        _value = value;
                        break;
                    }
                    case (AtomReference.Usage.Constant):
                    default:
                        throw new NotSupportedException("Can't reassign constant value");
                }
            }
        }

        public static implicit operator T(AtomReference<T, V, C> reference)
        {
            return reference.Value;
        }
    }
}
