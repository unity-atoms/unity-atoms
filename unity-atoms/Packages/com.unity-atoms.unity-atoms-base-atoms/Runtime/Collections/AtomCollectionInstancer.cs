using System;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// AtomCollection Instancer that creates an in memory copy of a Collection at runtime.
    /// </summary>
    [EditorIcon("atom-icon-hotpink")]
    [DefaultExecutionOrder(Runtime.ExecutionOrder.VARIABLE_INSTANCER)]
    [AddComponentMenu("Unity Atoms/Collections/Collection Instancer")]
    public sealed class AtomCollectionInstancer : AtomBaseCollectionInstancer<StringReferenceAtomBaseVariableDictionary, AtomCollection> { }
}
