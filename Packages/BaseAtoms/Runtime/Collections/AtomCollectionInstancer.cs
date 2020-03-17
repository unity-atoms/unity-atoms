using System;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    [EditorIcon("atom-icon-hotpink")]
    [DefaultExecutionOrder(Runtime.ExecutionOrder.VARIABLE_INSTANCER)]
    [AddComponentMenu("Unity Atoms/Instancers/Collection Instancer")]
    public sealed class AtomCollectionInstancer : AtomBaseCollectionInstancer<StringReferenceAtomBaseVariableDictionary, AtomCollection> { }
}
