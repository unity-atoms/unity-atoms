using System;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// An `AtomFunction&lt;int, int&gt;` that clamps the value using a min and a max value and returns it.
    /// </summary>
    [EditorIcon("atom-icon-sand")]
    [CreateAssetMenu(menuName = "Unity Atoms/Functions/Transformers/Clamp Int (int => int)", fileName = "ClampInt")]
    public class ClampInt : IntIntFunction, IIsValid
    {
        /// <summary>
        /// The minimum value.
        /// </summary>
        public IntReference Min;

        /// <summary>
        /// The maximum value.
        /// </summary>
        public IntReference Max;

        public override int Call(int value)
        {
            if (!IsValid()) { throw new Exception("Min value must be less than or equal to Max value."); }
            return Mathf.Clamp(value, Min.Value, Max.Value);
        }

        public bool IsValid()
        {
            return Min.Value <= Max.Value;
        }
    }
}
