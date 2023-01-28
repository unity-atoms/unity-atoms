using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.InputSystem;

namespace UnityAtoms.InputSystem
{
    public class CallbackContextInterpreter<T, P, C, V, E1, E2, F, VI> : BaseAtom
        where T : struct
        where P : struct, IPair<T>
        where C : AtomBaseVariable<T>
        where V : AtomVariable<T, P, E1, E2, F>
        where E1 : AtomEvent<T>
        where E2 : AtomEvent<P>
        where F : AtomFunction<T, T>
        where VI : AtomVariableInstancer<V, P, T, E1, E2, F>
    {
        [SerializeField] private E1 _started;
        [SerializeField] private E1 _performed;
        [SerializeField] private E1 _canceled;
        [SerializeField] private E1 _waiting;
        [SerializeField] private E1 _disabled;

        [SerializeField] private V _value;
        [SerializeField] private BoolVariable _valueAsButton;

        public void Raise(InputAction.CallbackContext context)
        {
            var value = context.ReadValue<T>();
            switch (context.phase)
            {
                case InputActionPhase.Disabled:
                    if (_disabled)
                    {
                        _disabled.Raise(value);
                    }
                    break;
                case InputActionPhase.Waiting:
                    if (_waiting)
                    {
                        _waiting.Raise(value);
                    }
                    break;
                case InputActionPhase.Started:
                    if (_started)
                    {
                        _started.Raise(value);
                    }
                    break;
                case InputActionPhase.Performed:
                    if (_performed)
                    {
                        _performed.Raise(value);
                    }
                    break;
                case InputActionPhase.Canceled:
                    if (_canceled)
                    {
                        _canceled.Raise(value);
                    }
                    break;
            }
        }

        public void UpdateValues(InputAction.CallbackContext context)
        {
            if (_value)
            {
                _value.Value = context.ReadValue<T>();
            }
            if (_valueAsButton)
            {
                _valueAsButton.Value = context.ReadValueAsButton();
            }
        }

        public void Interpret(InputAction.CallbackContext context)
        {
            Raise(context);
            UpdateValues(context);
        }
    }
}
