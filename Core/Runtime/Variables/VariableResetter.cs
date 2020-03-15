using System.Collections.Generic;
using UnityEngine;

namespace UnityAtoms
{
    [AddComponentMenu("Unity Atoms/Variable Resetter")]
    [DefaultExecutionOrder(Runtime.ExecutionOrder.VARIABLE_RESETTER)]
    public class VariableResetter : MonoBehaviour
    {
        public List<AtomBaseVariable> _variables = new List<AtomBaseVariable>();

        void OnEnable()
        {
            for (var i = 0; i < _variables.Count; ++i)
            {
                _variables[i].Reset();
            }
        }
    }
}