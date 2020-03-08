using UnityEngine;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms.FSM
{
    [EditorIcon("atom-icon-hotpink")]
    [AddComponentMenu("Unity Atoms/FSM/FSM Instancer")]
    public class FSMInstancer : AtomVariableInstancer<
        FiniteStateMachine,
        StringPair,
        string,
        StringEvent,
        StringPairEvent,
        StringStringFunction,
        AtomCollection,
        AtomList>
    {
        protected override void ImplSpecificSetup()
        {
            if (_base.TransitionStarted != null)
            {
                _inMemoryCopy.TransitionStarted = Instantiate(_base.TransitionStarted);
            }
            if (_base.CompleteCurrentTransition != null)
            {
                _inMemoryCopy.CompleteCurrentTransition = Instantiate(_base.CompleteCurrentTransition);
            }
        }
    }
}