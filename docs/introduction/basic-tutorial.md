---
id: basic-tutorial
title: Basic tutorial
hide_title: true
sidebar_label: Basic tutorial
---

# Basic tutorial

Below follows a step-by-step example of managing a player's health using Unity Atoms. If you haven't read the [Overview and philosopy](./overview.md) section you should do that before proceeding.

_NOTE: This tutorial is based on [this](https://medium.com/@adamramberg/unity-atoms-tiny-modular-pieces-utilizing-the-power-of-scriptable-objects-e8add1b95201) blog post._

## Decouple your scripts using Variables and Constants

Variables are storing data, for example primitives, reference types or structs as Scriptable Objects. Because Variables are stored as Scriptable Objects they are not part of any scene, but could instead be seen as part of the game’s global shared state. Variables are designed to make it easy to inject them (via the Unity Inspector) and share them between your MonoBehaviours. A Constant is a trimmed down version of a Variable and it's value can't be altered at runtime. Lets see an example on how to use Variables and Constants!

Imagine you have a `PlayerHealth.cs` script that contains the health of the game’s player. We will attach the script to a `GameObject` with a `SpriteRenderer`, `BoxCollider2D` and a `Rigidbody2D` called Player. The health is represented by an int, which corresponds to an `IntVariable` in Unity Atoms. The script will look like this:

```cs
public class PlayerHealth : MonoBehaviour
{
    public IntVariable Health;
}
```

In the game the player’s health will decrease when hitting something harmful. We will attach this `Harmful.cs` script to a GameObject called Harmful that also has a `SpriteRenderer` and a `BoxCollider2D` (as a trigger):

```cs
public class Harmful : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Player")
        {
            collider.GetComponent<Player>().Health.Value -= 10;
        }
    }
}
```

Finally we will add an UI `HealthBar.cs` script that we attach to a `GameObject` (inside a UI Canvas) with a `RectTransforn`, `CanvasRenderer` and UI `Image` component. The `HealthBar.cs` script will update the `Image` representing the health bar when the player’s health is changing:

```cs
public class HealthBar : MonoBehaviour
{
    [SerializeField]
    private IntVariable Health;
    [SerializeField]
    private IntConstant MaxHealth;

    void Update()
    {
        GetComponent<Image>().fillAmount = 1.0f * Health.Value / MaxHealth.Value;
    }
}
```

Since the player's health is going to change at runtime we make `Health` an `IntVariable` while `MaxHealth` is not going to be changed at runtime is therefore created as an `IntConstant`, They are both global assets stored as `.assets` files that are (or could be) shared between scripts. To create these `.assets` files we can right click somewhere in the Project window, and go _Create / Unity Atoms / Variables / Int_ to create the Variable and go _Create / Unity Atoms / Constants / Int_ to create the Constant. The Variable looks like this in the Unity Inspector:

![int-variable_player-health-v1](assets/int-variable_player-health-v1.png)

And the Constant looks like this:

![int-variable_player-health](assets/int-constant_max-player-health.png)

The `Developer Description` is a text describing the Variable in order to document it, the `Value` is the actual value of the Variable, and `Old Value` is the last value the Variable had after it was changed via code. `Changed` and `Changed With History` will be explained later in this tutorial. We name the `IntVariable` created to `Health` and the `IntConstant` to `MaxHealth` and set both their initial value to 100. After they are created we can drop them on the `PlayerHealth` and `HealthBar` components via Unity’s inspector like this:

![player-health-script](assets/player-health-script.png)

![healthbar-script-v1](assets/healthbar-script-v1.png)

Variables gives us a way of separating our game’s shared state from the actual implementation. It also makes our code less coupled since we do not need to reference other MonoBehaviours in our scripts, eg. we do not need to reference the `PlayerHealth.cs` script in our `HealthBar.cs` script like this:

```cs
[SerializeField]
private Player player;
```

Hurray for less coupled code! 🎉

## Make it more data driven using Events

Events are things that happens in our game that other scripts or entities could listen and subscribe to. Events are (like Variables) also Scriptable Objects that lives outside of a specific scene. In Unity Atoms Events can be of different types and thereby pass a long data to listeners. Variables do by default have the possibility to raise two specific Events:

-   `Changed` — raised every time a Variable’s value is changed. The Event contains the new value.
-   `Changed With History` — also raised every time a Variable’s value is changed. However, this Event contains both the new and the old value.

This makes it easier to make our game more data driven than just using Variables. Lets take a look at how that looks in our last example. We can create a new `IntEvent` as a `.asset` file by right clicking and go _Create / Unity Atoms / Event / Int_ and name it `HealthChangedEvent`:

![health-changed-event](assets/health-changed-event.png)

And then drop it on our `IntVariable` for the player’s health like this:

![int-variable_player-health-v2](assets/int-variable_player-health-v2.png)

We can then modify our `HealthBar.cs` script to look like this:

```cs
public class HealthBar : MonoBehaviour
{
    [SerializeField]
    private IntEvent HealthChangedEvent;
    [SerializeField]
    private IntVariable MaxHealth;

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

![healthbar-script-v2](assets/healthbar-script-v2.png)

We now react to global state changes instead of checking the Variable value each Update tick. In other words we only update our `Image` component when we actually need to. That is pretty sweet!

## Seperate concerns using Listeners

There is still an issue that the `HealthBar.cs` script is in charge of registering itself as a listener and at the same time defining what happens when a Event is raised. We need to seperate its concerns! This brings us to the third concept of Unity Atoms, Listeners. A Listener listens (sometimes also referred to as observes or subscribes) to a Event and responds by firing off zero to many responses. Listeners are MonoBehaviours and therefore lives in a scene. They can be seen as the glue between Events and Actions (see the next section of this post).

The `HealthBar.cs` script from our last example is actually a Listener, but a very specific implementation of it. We can do better than that! Lets create a Game Object in our scene and call it `HealthListener`. Unity Atoms comes with some predefined Listeners. In this case we want to listen to an `IntEvent` so we will press the Add Component button on our `HealthListener`, create an IntListener and drop in the `HealthChangedEvent`:

![health-listener](assets/health-listener-v1.png)

We can now shave off some of the code in our `HealthBar.cs` script to look like this:

```cs
public class HealthBar : MonoBehaviour
{
    [SerializeField]
    private IntVariable MaxHealth;

    public void ChangeFillAmount(int health)
    {
        GetComponent<Image>().fillAmount = 1.0f * health / MaxHealth.Value;
    }
}
```

And then go back to our `HealthListener`’s IntListener component, press the + to add an Unity Event Response, drop in the `HealthBar` component (from the scene) and point out the `HealthChanged` function defined above:

![health-listener](assets/health-listener-v2.png)

The `HealthBar.cs` script is now only responsible for what happens when our player’s health is changing. Pretty great, huh?

## Create an Action as a response

The `HealthChanged` function created above is actually a Response of type `UnityEvent`. However, in Unity Atoms there is also the possibility to create Responses as Scriptable Objects called Actions. An Action is a function as a Scriptable Object that does not return a value. As a side note there are also Functions in Unity Atoms, which are exactly like Actions, but does return a value. To demonstrate the concept of an Action as a Response lets create an Action called `HealthLogger.cs` that gives some love to the console and logs the player’s health whenever it changes:

```cs
[CreateAssetMenu(menuName = "Unity Atoms/Examples/Health Logger")]
public class HealthLogger : IntAction
{
    public override void Do(int health)
    {
        Debug.Log("<3: " + health);
    }
}
```

It is possible to create the `HealthLogger` by right clicking and go _Create / Unity Atoms / Examples / Health Logger_ (this is available due to the call to `CreateAssetMenu`). When created we can add it as an Action Response to the `HealthListener`:

Every time the player’s health is changed we now log out the player’s health. This particular example is pretty simple, but I’m sure you can come up with lots of other use cases for it (for example play a sound or emit some particles).

That is it! We have covered the four most fundamental core pieces of Unity Atoms.

## Use Mono Hooks to keep yourself DRY

Mono Hooks are Unity's lifecycles as Events. A great use for Mono Hooks in our example would allow us to remove the `Harmful.cs` script created earlier. We could instead attach a `OnTrigger2DHook.cs` to the Harmful GameObject and toggle on `Trigger On Enter` like this:

![mono-hooks-trigger-2d](assets/mono-hooks-trigger-2d.png)

We could then create a Collider2DAction called `DecreasePlayersHealth.cs` and add it to a Collder2D Listener attached to the Harmful GameObject:

```cs
    public class DecreasePlayersHealth : Collider2DAction
    {
        public override void Do(Collider2D collider)
        {
            if (collider.tag == "Player")
            {
                collider.GetComponent<PlayerHealth>().Health.Value -= 10;
            }
        }
    }
```

![mono-hooks-listener](assets/mono-hooks-listener.png)
