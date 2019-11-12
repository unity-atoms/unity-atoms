using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace UnityAtoms.Conditions
{
    public class Condition : MonoBehaviour
    {
        [Header("If")]
        // TODO: Should be a List of BaseCondition, but I couldn't make it draw on the inspector
        public List<IntCondition> Conditions;
        [Header("Then")]
        public VoidEvent AtomEventIfTrue;
        public UnityEvent UnityEventIfTrue;
        [Header("Else")]
        public VoidEvent AtomEventIfFalse;
        public UnityEvent UnityEventIfFalse;

        public void Awake()
        {
            CheckConditions();
        }

        public void CheckConditions()
        {
            bool isTrue = true;
            foreach (var item in Conditions)
            {
                if (item.IsTrue() == false)
                {
                    isTrue = false;
                    break;
                }
            }
            if (isTrue)
            {
                if (AtomEventIfTrue != null)
                    AtomEventIfTrue.Raise();

                UnityEventIfTrue.Invoke();
            }
            else
            {
                if (AtomEventIfFalse != null)
                    AtomEventIfFalse.Raise();

                UnityEventIfFalse.Invoke();
            }
        }
    }
}
