using System;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// An `AtomFunction&lt;float, float&gt;` that clamps the value using a min and a max value and returns it.
    /// </summary>
    [EditorIcon("atom-icon-sand")]
    [CreateAssetMenu(menuName = "Unity Atoms/Functions/Transformers/Clamp Float (float => float)", fileName = "ClampFloat")]
    public class ClampFloat : FloatFloatFunction, IIsValid
    {
        /// <summary>
        /// The minimum value.
        /// </summary>
        public FloatReference Min;

        /// <summary>
        /// The maximum value.
        /// </summary>
        public FloatReference Max;

        public override float Call(float value)
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
