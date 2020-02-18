---
id: generator
title: Generator
hide_title: true
sidebar_label: Generator
---

# Generator

The Generator is a powerful tool that allows you to generate your own Atoms fast and easy via an Unity editor window. It liberates you from writing otherwise tedious boilerplate code and lets you instead focus on what is important. The Generator can be found by clicking on _Tools / Unity Atoms / Generator_ in the top menu bar:

![generator_top-bar-menu](assets/generator_top-bar-menu.png)

The Generator looks like this:

![generator_window](assets/generator_window.png)

## Options

### Relative write path

The path where the generated Atoms will be written to. The path is relative to your project's root folder (Assets).

### Type name

This is the name of the type that you want to generate. Lets say you want to create your own struct and generate Atoms for it:

```cs
public struct MyStruct
{
    public int Number;
}

```

You would then type `MyStruct` as the type name.

### Is type Equatable?

Is the type provided in the above field implementing [`IEquatable`](https://docs.microsoft.com/en-us/dotnet/api/system.iequatable-1?view=netframework-4.8)? You need to add the following to `MyStruct` to make it implement `IEquatable`:

```cs
using System;

public struct MyStruct : IEquatable<MyStruct>
{
    public int Number;

    public bool Equals(MyStruct other)
    {
        return this.Number == other.Number;
    }

    public override bool Equals(object obj)
    {
        return Equals((MyStruct)obj);
    }

    public override int GetHashCode()
    {
        return Number.GetHashCode();
    }
}

```

If your type does not implement [`IEquatable`](https://docs.microsoft.com/en-us/dotnet/api/system.iequatable-1?view=netframework-4.8) you will need to manually implement the `AreEqual` method in the generated `AtomVariable`.

### Type namespace

Enter the namespace of the type that you have provided. If for example `MyStruct` was under the namespace `MyNamespace`:

```cs
namespace MyNamespace
{
    public struct MyStruct : IEquatable<MyStruct>
    {
        // ...
    }
}

```

You would then enter `MyNamespace`as the type namespace.

### Sub Unity Atoms namespace

By default the Atoms that gets generated will be under the namespace `UnityAtoms`. If you for example like it to be under `UnityAtoms.MyNamespace` you would then enter `MyNamespace` in this field.

### Type(s) to generate

This is a list of Atom types that you want to generate. Simply select the Atoms that you want to generate. Some Atoms depends on other Atoms. If you unselect an Atom that other Atoms depends on, then the Generator will unselect those depending Atoms. Below you find the dependency graph:

-   List - depends on Event
-   Listener - depends on Action, Variable, Event, Event x 2, Function x 2, Variable Instancer, Event Reference and Unity Event
-   Listener x 2 - depends on Action x 2, Variable, Event, Event x 2, Function x 2, Variable Instancer, Event x 2 Reference and Unity Event x 2
-   Reference - depends on Constant, Variable, Event, Event x 2, Function x 2 and Variable Instancer
-   Set Variable Value - depends on Event, Event x 2, Function x 2, Variable, Constant, Reference, Variable Instancer
-   Variable - depends on Event, Event x 2 and Function x 2
-   Variable Instancer - depsends on Variable, Event, Event x 2, Function x 2
-   Event Reference - depends on Variable, Event, Event x 2, Function x 2, Variable Instancer
-   Event x 2 Reference - depends on Variable, Event, Event x 2, Function x 2, Variable Instancer

### Close & Generate

The close button will close the window, while the generate button will generate your Atoms.
