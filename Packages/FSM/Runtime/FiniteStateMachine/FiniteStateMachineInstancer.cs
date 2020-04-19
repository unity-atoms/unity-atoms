using UnityEngine;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms.FSM
{
    /// <summary>
    /// Takes a base FSM and creates an in memory copy of it on OnEnable. Removes the FSM on OnDestroy.
    /// </summary>
    [EditorIcon("atom-icon-hotpink")]
    [AddComponentMenu("Unity Atoms/FSM/Finite State Machine Instancer")]
    public class FiniteStateMachineInstancer : StringVariableInstancer
    {
        public override StringVariable Base { get => (StringVariable)_fsmBase; }

        /// <summary>
        /// The variable that the in memory copy will be based on when created at runtime.
        /// </summary>
        [SerializeField]
        private FiniteStateMachine _fsmBase = null;

        protected override void ImplSpecificSetup()
        {
            if (((FiniteStateMachine)Base).TransitionStarted != null)
            {
                ((FiniteStateMachine)_inMemoryCopy).TransitionStarted = Instantiate(((FiniteStateMachine)Base).TransitionStarted);
            }
            if (((FiniteStateMachine)Base).CompleteCurrentTransition != null)
            {
                ((FiniteStateMachine)_inMemoryCopy).CompleteCurrentTransition = Instantiate(((FiniteStateMachine)Base).CompleteCurrentTransition);
            }
        }
    }
}