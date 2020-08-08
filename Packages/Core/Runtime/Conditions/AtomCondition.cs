using System;
using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Base abstract class for Conditions. Condition must be an AtomFunction<bool, T>.
    /// </summary>
    public abstract class AtomCondition<T> : AtomFunction<bool, T>
    {
    }
}
