---
id: unirx
title: Usage with UniRX
hide_title: true
sidebar_label: Usage with UniRX
---

# Usage with UniRX

Variables and Events exposes methods that returns [`IObservables`](https://docs.microsoft.com/en-us/dotnet/api/system.iobservable-1?view=netframework-4.8). Atom Variables exposes `ObserveChange` and `ObserveChangeWithHistory`, while Atom Events exposes `Observe`. This makes it possible to use Unity Atoms seamlessly together with [UniRx](https://github.com/neuecc/UniRx).

## Simple example

The `HealthBar.cs` script from the [Basic tutorial](./basic-tutorial) could be rewritten like this using UniRx:

```cs
using UnityEngine;
using UnityEngine.UI;
using UniRx;

public class HealthBar : MonoBehaviour
{
    [SerializeField]
    private IntConstant _maxHealth = null;
    [SerializeField]
    private IntVariable _health = null;

    void Awake()
    {
        _health.ObserveChange().Subscribe(health =>
        {
            GetComponent<Image>().fillAmount = 1.0f * health / _maxHealth.Value;
        });
    }
}
```

## Advanced example

Here is another example of a `PlayerMove.cs` script that is a little bit more advanced. Horizontal and vertical input is only getting a value from the `Input` class as long as the UI state is in the state of `_uiStatePlaying`.

_NOTE: This example is also using [Marvelous](https://github.com/AdamRamberg/marvelous) for its `MergeObservables` method._

```cs
using System;
using UnityEngine;
using Marvelous;
using UniRx;

public class PlayerMove : MonoBehaviour
{
    [SerializeField]
    private StringVariable _uiState;
    [SerializeField]
    private StringConstant _uiStatePlaying;

    private void Awake()
    {
        float _horizontal = 0f, _vertical = 0f;
        string HORIZONTAL = "Horizontal", VERTICAL = "Vertical";

        Observable.EveryUpdate().MergeObservables<long, string, ValueTuple<long, string>>(
            observable2: _uiState.ObserveChange(),
            createCombinedModel: (frame, state) => new ValueTuple<long, string>(frame, state),
            initialValue2: _uiState.Value
        ).Subscribe(t =>
        {
            _horizontal = t.Item2 == _uiStatePlaying.Value ? Input.GetAxis(HORIZONTAL) : 0f;
            _vertical = t.Item2 == _uiStatePlaying.Value ? Input.GetAxis(VERTICAL) : 0f;
        });

        Observable.EveryFixedUpdate().Subscribe(t =>
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(_horizontal, _vertical) * 5f;
        });
    }
}
```

Using Unity Atoms together with UniRx and Marvelous (for its `MergeObservables`) makes your scripts really data driven.
