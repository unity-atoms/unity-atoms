
using System;

using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/Object", fileName = "ObjectVariable")]
    public sealed class ObjectVariable : AtomVariable<object, ObjectEvent, ObjectObjectEvent>
    {
        protected override bool AreEqual(object first, object second)
        {
            return (first == null && second == null) || (first != null && first == second);
        }
    }

}
