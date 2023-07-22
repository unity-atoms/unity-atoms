---
id: variable-transformers
title: Variable Pre Change Transformers
hide_title: true
sidebar_label: Variable Pre Change Transformers
---

# Variable Pre Change Transformers

Variable pre change transformers provide a way to modify the value of a Variable before it gets changed. These are used to introduce customized logic into the process of updating the value of an Variable. For example, a pre change transformer could be used to limit a player's health within certain boundaries, such as ensuring that it never drops below zero.

In this tutorial, we'll look at how to use a pre change transformer in UnityAtoms.

## Step 1: Create a Pre Change Transformer

Firstly, we need to create a new class for our pre change transformer. Let's say we are going to create a transformer that ensures the health of our player never falls below 0. 

Create a new C# script and name it `MinHealthTransformer`. This script should extend `IntIntFunction` and override the `Call` method:

```
using UnityAtoms.BaseAtoms;

[EditorIcon("atom-icon-sand")]
[CreateAssetMenu(menuName = "Unity Atoms/Functions/Transformers/MinHealth Int (int => int)", fileName = "MinHealth")]
public class MinHealthTransformer : IntIntFunction
{
    public override int Call(int value)
    {
        if (value < 0)
            return 0;
        else
            return value;
    }
}
```

In the `Call` method, we're checking if the new value of health is less than 0. If so, we're returning 0 instead of the new value. This ensures the player's health never drops below 0.

## Step 2: Use the Pre Change Transformer

To use this transformer, we need to create a ScriptableObject of this type. 

In the Unity Editor:

1. Right-click in the project window and choose `Create > UnityAtoms > Functions > Transformers > MinHealth Int (int => int)`.
2. Name the Object `MinHealthTransformer`.
3. In the inspector window, set the `Pre Change Transform` to be `MinHealthTransformer`.

Now, whenever the `PlayerHealth` value is changed, the `MinHealthTransformer`'s `PreChangeCheck` method will be called, ensuring the health never drops below 0.


## Notes

As the name suggests, pre change transformers are executed _before_ the change events are invoked.
