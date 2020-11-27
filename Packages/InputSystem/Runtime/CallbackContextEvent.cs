using UnityAtoms;
using UnityEngine.InputSystem;

public class CallbackContextEvent<T, P, C, V, E1, E2, F, VI> : BaseAtom
    where T : struct
    where P : struct, IPair<T>
    where C : AtomBaseVariable<T>
    where V : AtomVariable<T, P, E1, E2, F>
    where E1 : AtomEvent<T>
    where E2 : AtomEvent<P>
    where F : AtomFunction<T, T>
    where VI : AtomVariableInstancer<V, P, T, E1, E2, F>
{
    public E1 any;
    public E1 started;
    public E1 performed;
    public E1 canceled;
    public E1 waiting;
    public E1 disabled;

    public V variable;

    public void Raise(InputAction.CallbackContext context)
    {
        switch(context.phase)
        {
            case InputActionPhase.Disabled:
                disabled?.Raise();
                break;
            case InputActionPhase.Waiting:
                waiting?.Raise();
                break;
            case InputActionPhase.Started:
                started?.Raise();
                break;
            case InputActionPhase.Performed:
                performed?.Raise();
                break;
            case InputActionPhase.Canceled:
                canceled?.Raise();
                break;
        }
        any?.Raise();
    }

    public void RaiseWithValue(InputAction.CallbackContext context)
    {
        var value = context.ReadValue<T>();
        switch(context.phase)
        {
            case InputActionPhase.Disabled:
                disabled?.Raise(value);
                break;
            case InputActionPhase.Waiting:
                waiting?.Raise(value);
                break;
            case InputActionPhase.Started:
                started?.Raise(value);
                break;
            case InputActionPhase.Performed:
                performed?.Raise(value);
                break;
            case InputActionPhase.Canceled:
                canceled?.Raise(value);
                break;
        }
        any?.Raise(value);
    }

    public void UpdateVariable(InputAction.CallbackContext context)
    {
        variable.Value = context.ReadValue<T>();
    }
}
