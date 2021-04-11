using System;
using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Base abstract class for Conditions. Condition must be an AtomFunction&lt;bool, T&gt;.
    /// </summary>
    public abstract class AtomCondition<T> : AtomFunction<bool, T>
    {
    }
}
