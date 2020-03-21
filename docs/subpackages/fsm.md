---
id: fsm
title: FSM
hide_title: true
sidebar_label: FSM
---

# Unity Atoms / FSM

Finite state machine implemented using Unity Atoms.

## API

Check out the [API](../api/unityatoms.fsm).

## What is it?

A finite state machine implementation for Unity Atoms. The package was inspired by [this](https://github.com/dubit/unity-fsm) open source Unity FSM repo. The FSM in Unity Atoms is actually derrived from `StringVariable`, so everything you can do with a `StringVariable` you can also do with a FSM.

## Concepts

A finite state machine is composed of 2 things:

1. States - a list of possible states. A state is either a string of a sub finite state machine (oh yes, FSM's can be nested).
2. Transitions - a list of possible transitions. State can only be altered to another state based on the transitions defined here.

In order to change state you need to dispatch a command and that command must be defined in your transitions for the current state.

## Example

Here is a simple example taken from [here](https://github.com/dubit/unity-fsm)

```
          "CLOSE"               "LOCK"
    +-------->---------+  +-------->---------+
    |                  |  |                  |
 +----+              +------+              +------+
 |OPEN|              |CLOSED|              |LOCKED|
 +----+              +------+              +------+
    |                  |  |                  |
    +--------<---------+  +--------<---------+
           "OPEN"                "UNLOCK"
```

This FSM has 3 states:

-   `OPEN`
-   `CLOSED`
-   `LOCKED`.

It also has 4 transitions:

-   From `OPEN`, to `CLOSED` when dispatching `CLOSE`.
-   From `CLOSED`, to `LOCKED` when dispatching `LOCK`.
-   From `LOCKED`, to `CLOSED` when dispatching `UNLOCK`.
-   From `CLOSED`, to `OPEN` when dispatching `OPEN`.

## States

-   `Id` - the state name / identifier (string)
-   `Cooldown` - if set to above 0 the state machine will re set the state every `n` th seconds where `n` is the cooldown specified in seconds. If for example cooldown is set to 1 and the state id is set to `SECOND`, then the state machine will be set to `SECOND` every second. This means that you will receive that value in the FSM's Changed Event.
-   `Sub Machine` - FSMs can be nested. If specified this sub machine will take over resolving the state value.

## Transitions

-   `From State` - The state that we transition from.
-   `To State` - The state that we transition to.
-   `Command` - The command that needs to be dispatched in order to begin this transition.
-   `Test Condition` - If specified this condition must be true in order to start the transition.
-   `Raise Event To Complete Transition` - If set to true the transition will not complete automatically, Instead you will need to manually Raise the Complete Current Transition Event.

## Hooks

-   `OnUpdate` - Calls a handler with the state value each Update.
-   `OnFixedUpdate` - Calls a handler with the state value each FixedUpdate.
-   `DispatchWhen` - Defines a command that is going to automatically be dispatched when the condition provided is met.
-   `OnStateCooldown` - Calls the handler of every state cooldown.

## Funcs

-   `Reset` - Reset the FSM.
-   `Dispatch` - Dispatch / raise a command.

## Simple example

A simple example showing how you can move a rigidibody towards a target depending on if the current state of the FMS is set to `CHASING` or not.

```cs
public class EnemyMovement : MonoBehaviour
{
    [SerializeField]
    private StringReference _tagToTarget;

    [SerializeField]
    private FloatReference _shootingRange = new FloatReference(5f);

    [SerializeField]
    private FloatReference _moveSpeedMultiplier = new FloatReference(2f);

    [SerializeField]
    private FiniteStateMachineReference _enemyState;


    void Awake()
    {
        Transform target = null;
        AtomTags.OnInitialization(() => target = AtomTags.FindByTag(_tagToTarget.Value).transform);
        var body = GetComponent<Rigidbody2D>();

        _enemyState.Machine.OnUpdate((deltaTime, value) =>
        {
            if (target)
            {
                body.Move((target.position - transform.position), value == "CHASING" ? 2f : 0f, deltaTime);
            }
        }, gameObject);
        _enemyState.Machine.DispatchWhen(command: "ATTACK", (value) => target != null && value == "CHASING" && (_shootingRange.Value >= Vector3.Distance(target.position, transform.position)), gameObject);
        _enemyState.Machine.DispatchWhen(command: "CHASE", (value) => target != null && value == "ATTACKING" && (_shootingRange.Value < Vector3.Distance(target.position, transform.position)), gameObject);
    }
    }
```
