using System;
using UnityEngine;
using UnityEngine.Assertions;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// AtomList Instancer that creates an in memory copy of a List at runtime.
    /// </summary>
    [EditorIcon("atom-icon-hotpink")]
    [DefaultExecutionOrder(Runtime.ExecutionOrder.VARIABLE_INSTANCER)]
    [AddComponentMenu("Unity Atoms/Collections/List Instancer")]
    public sealed class AtomListInstancer : AtomBaseCollectionInstancer<AtomBaseVariableList, AtomList> { }
}
