using System;
using System.Collections.Generic;
using UnityEngine;

namespace UnityAtoms
{
    public abstract class ScriptableObjectVariableBase<T> : ScriptableObject, IWithValue<T>
    {
        [Multiline]
        public string DeveloperDescription = "";

        public virtual T Value { get { return value; } set { } }

        [SerializeField]
        protected T value;
    }
}