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

public class HealthBarUniRx : MonoBehaviour
{
    [SerializeField]
    private IntVariable _health = null;

    void Awake()
    {
        _health.ObserveChange().Subscribe(health =>
        {
            GetComponent<Image>().fillAmount = 1.0f * health / _health.InitialValue;
        });
    }
}
```

## Advanced example

Here is another example of a `PlayerMove.cs` script that is a little bit more advanced. Horizontal and vertical input is only getting a value from the `Input` class as long as the UI state is in the state of `_uiStatePlaying`.

_NOTE: This example is also using [Marvelous](https://github.com/AdamRamberg/marvelous) for its `Fuse` method._

```cs
using System;
using UnityEngine;
using Marvelous;
using UniRx;
using UnityAtoms.BaseAtoms;

public class PlayerMoveUniRx : MonoBehaviour
{
    [SerializeField]
    private StringVariable _uiState;
    [SerializeField]
    private StringConstant _uiStatePlaying;

    private void Awake()
    {
        float _horizontal = 0f, _vertical = 0f;
        string HORIZONTAL = "Horizontal", VERTICAL = "Vertical";

        Observable.EveryUpdate().Fuse<long, string>(
            _uiState.ObserveChange(),
            initialValue2: _uiState.Value
        ).Subscribe(t =>
        {
            var (_, state) = t;
            _horizontal = state == _uiStatePlaying.Value ? Input.GetAxis(HORIZONTAL) : 0f;
            _vertical = state == _uiStatePlaying.Value ? Input.GetAxis(VERTICAL) : 0f;
        });

        Observable.EveryFixedUpdate().Subscribe(t =>
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(_horizontal, _vertical) * 5f;
        });
    }
}
```

Using Unity Atoms together with UniRx and Marvelous (for its `Fuse`) makes your scripts really data driven.
