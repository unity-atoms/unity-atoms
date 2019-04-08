# ⚛️ Unity Atoms
*Tiny modular pieces utilizing the power of Scriptable Objects*

Read [this](https://medium.com/@adamramberg/unity-atoms-tiny-modular-pieces-utilizing-the-power-of-scriptable-objects-e8add1b95201) article on Medium for a great introduction to Unity Atoms.

## Influences
Unity Atoms is derrived from and a continuation of Ryan Hipple's [talk](https://www.youtube.com/watch?v=raQ3iHhE_Kk&t=2787s) from Unite 2017. The original source code can be found [here](https://github.com/roboryantron/Unite2017).

[This](https://www.youtube.com/watch?v=6vmRwLYWNRo&t=738s) talk by Richard Fine is a forerunner to Ryan Hipple's talk during Unite 2016.

## Motivation
The general approach to building scripts in Unity often generates a code base that is monolithic. This results in that your code is cumbersome to test, non-modular and hard to debug and understand.

Unity Atoms is an open source library that aims to make your game code: 
- 📦 Modular *- avoid scripts and systems directly dependent on each other*
- ✏️ Editable *- Scriptable Objects makes it possible to make changes to your game at runtime*
- 🐞 Debuggable *- modular code is easier to debug than tightly coupled code*

## Introduction
Before you start looking into this library you should watch the video above ☝️ and read [this](https://unity3d.com/how-to/architect-with-scriptable-objects) article on how to architect your game with Scriptable Objects.

## Installation
*Prerequisite: Since Unity Atoms is using the Unity Package Manager (UPM) you need to use Unity version 2018.3 >=*

There are 2 versions you can install, either the stable version (master branch) or the canary version (latest and greatest - canary branch). Be aware that the canary version might sometimes break. 

### Stable
Go to your projects `Packages/manifest.json` and add this:
     "dependencies": {
        ...
        "com.mambojambostudios.unity-atoms": "https://github.com/AdamRamberg/unity-atoms.git",
        ...
     }

### Canary
Go to your projects `Packages/manifest.json` and add this:
     "dependencies": {
        ...
        "com.mambojambostudios.unity-atoms": "https://github.com/AdamRamberg/unity-atoms.git#canary",
        ...
     }


## Usage
Unity Atoms is an event based system that encourages the game to be as data-driven as possible. The 4 most fundamental pieces (atoms) of Unity Atoms are: 
- Variables
- (Game) Events
- (Game Event) Listeners
- Responses

### Variables 
Variables are data / variables stored as Scriptable Objects. Because Variables are stored as Scriptable Objects they are not part of any scene, but could be instead be seen as part of a global shared game state. Variables are also designed to make it easy to inject (via the Unity Inspector) to your MonoBehaviours. 

It is possible to attach an event to a Variable that gets raised when its updated. This makes it possible to write more data-driven code.

It is also possible to attach another event to a Variable that also gets raised when a Variable is changed, but that contains both the old and the new value of the Variable.

Unity Atoms also offer some variations / additions to Variables such as Contants, References and Lists.

#### Constants
Exactly the same as Variables, but can not be changed via script and therefore does not contain the change events that Variables does. The idea is to use Constants for for example tags instead of hard coding tags in your scripts. 

#### References
References can be toggled between "use as constant" or "use variable" via the Unity Inspector. When a reference is "used as constant" then it functions exactly like a regular serialized variable in a MonoBehaviour script. However, when it is set to "use variable" it functions exactly like a Variable.

#### Lists
A list is an array of values that is stored as a Scriptable Object. There is the possibility to add Game Events for when the following happens to the list: 
- An item is added to the list. 
- An item is removed from the list. 
- The list is cleared.

### Game Events 
A game event is a thing that happens in the game that others could listen / subscribe to. Game events are also Scriptable Objects that lives outside of a specific scene. It is possible to raise a Game Event from the Unity Inspector for debug purposes.

### Game Event Listeners 
A listener listens / observes / subscribes to an event and raises / invokes zero to many responses to that event. Game Event Listeners are Monobehaviours and lives in a scene. See below for more information on the type of responses there are. 

### Responses 
A responses is raised by a listener in response to an event. Responses can live both in the scene as [UnityEvents](https://docs.unity3d.com/ScriptReference/Events.UnityEvent.html) or outside the scene as a Scriptable Object in the shape of a Game Action or a Game Function.

#### Game Actions
A Game Action is a C# function as a Scriptable Object. A Game Function can be used as a response in a Game Event Listener. 

#### Game Functions
A Game Function is basically the same as a Game Action, but while a Game Actions does not return something a Game Function does. 

### Mono Hooks
Mono Hooks is a way to make it possible to have Unity lifecycle methods as events. The main reason for this is to make this pattern consistent and possible to use in ALL of your code. 

## Further Notes
When you start thinking about this pattern you will realize that everything can be explained using the atoms above. The native Unity lifecycle methods can be thought of as variation of the pattern above, where events gets raised and passes a long data (eg. OnTriggerEnter2D) and you write a response to that event. 

## Examples
Examples can be found in the UnityAtomsTestsAndExamples folder.

## Contribution
Would ❤️ if you would like to contribute to the project. Post me a message, create an issue or start working on an existing issue if you want to contribute. 

### Project structure
- Source - contains all the source code for the library
- UnityAtomsTestsAndExamples - this folder is a Unity project folder that contains examples and tests. This folder is not included in the distribution of Unity Atoms. 

The reason for this project structure is that we want to include tests and examples in the repo (both needing a Unity project), but there are at the same time currently some restrictions when using the UPM regarding how to import it to your project. 

#### UPM doesn't allow... 
- importing a sub folder in a Git repo. 
- excluding files (using property "files" in package.json) when importing locally using the file syntax (eg. "com.mambojambostudios.unity-atoms-src": "file:../../Source"). 
- package.json in subdirectories (only root level)

#### Current project structure therefore allows for... 
- including an example repo for examples and tests
- use the local source in the example repo
- referencing this git repo in another project's manifest file

### Style Guide

#### Language Usage
* Mark closed types as sealed to enable proper devirtualization (see [here](https://blogs.unity3d.com/2016/07/26/il2cpp-optimizations-devirtualization/) for more info).
* Avoid LINQ usage for runtime usage except where absolutely possible (`ToList` or `ToArray` for example) and avoid using `ForEach`. Using these methods creates easily avoidable garbage. Editor usage is another story as performance is not as generally important.

#### Layout
There is an `.editorconfig` at the root of the repository located [here](/.editorconfig) that can be used by most IDEs to help ensure these settings are automatically applied.
* **Indentation:** 1 tab = 4 spaces (no tab character)
* **Desired width:** 120-130 characters max per line
* **Line Endings:** Unix (LF), with a new-line at the end of each file.
* **White Space:** Trim empty whitespace from the ends of lines.

#### Naming and Formatting
* Namespaces, Defined Types, Methods, and Events should all be in upper pascal case.
* Public fields should be in lower pascal case like `isLoaded` while private fields should be lower pascal case prefixed with a `_` character like `_isLoaded`.
* Public and private properties should be in upper pascal case `IsLoaded`.
* Readonly, static, or const fields should be in upper pascal case `IsLoaded`.

#### Structure
* Follow good encapsulation principles and try to limit exposing fields directly as public; unless necessary everything should be marked as private/protected unless necessary. Where public access to a field is needed, use a public property instead.
* Where classes or methods are not intended for use by a user, mark these as `internal`.
* Order class structure like so:
    * Namespace
        * Internal classes
        * Properties (Public/Private)
        * Fields (Public/Private)
        * Unity Methods
        * Primary Methods
        * Helper Methods
* Lines of code that are generally longer than 120-130 characters should generally be broken out into multiple lines. For example, instead of:

`public bool SomeMethodWithManyParams(int param1, float param2, List<int> param3, out int param4, out int param5)...`

do

```
public bool SomeMethodWithManyParams(
     int param1,
     float param2,
     List<int> param3,
     out int param4,
     out int param5)...
 ```

#### Example Formatting
```
using System;
using UnityEngine;

namespace Example
{
    public class Foo : MonoBehavior
    {
        public int SomeValue { get { return _someValue; } }

        [SerializeField]
        private int _someValue;

        private const string Warning = "Somethings wrong!";

        private void Update()
        {
            // Do work
            Debug.Log(Warning);
        }
    }
}
```

### Pull requests
Pull requests should be made to the [canary branch](https://github.com/AdamRamberg/unity-atoms/tree/canary).
