---
id: events
title: Events
hide_title: true
sidebar_label: Events
---

# Events

Events are things that happens in our game that other scripts or entities could listen and subscribe to. Events are (like Variables) also Scriptable Objects that live outside of a specific scene. In Unity Atoms Events can be of different types and thereby pass along data to listeners. Variables do by default have the possibility to raise two specific Events:

-   `Changed` — raised every time a Variable’s value is changed. The Event contains the new value.
-   `Changed With History` — also raised every time a Variable’s value is changed. However, this Event contains both the new and the old value.

This makes it easier to make our game more data driven than just using Variables. Lets take a look at how that looks in our last example. We can [create](./creating-atoms.md) a new `IntEvent` and called `HealthChangedEvent`. Drop it on our `IntVariable` for the player’s health like this:

![health-changed-event-drop](../assets/events/health-changed-event-drop.gif)

We can then modify our `HealthBar.cs` script to look like this:

```cs
using UnityEngine;
using UnityEngine.UI;
using UnityAtoms.BaseAtoms;

public class HealthBar : MonoBehaviour
{
    [SerializeField]
    private IntEvent HealthChangedEvent;
    [SerializeField]
    private IntConstant MaxHealth;

    void Start()
    {
        HealthChangedEvent.Register(this.ChangeFillAmount);
    }

    void OnDestroy()
    {
        HealthChangedEvent.Unregister(this.ChangeFillAmount);
    }

    private void ChangeFillAmount(int health)
    {
        GetComponent<Image>().fillAmount = 1.0f * health / MaxHealth.Value;
    }
}
```

And then inject the `HealthChangedEvent` to our `HealthBar` component:

![events-to-healthbar](../assets/events/events-to-healthbar.gif)

We now react to global state changes instead of checking the Variable value each Update tick. In other words we only update our `Image` component when we actually need to. That is pretty sweet!
