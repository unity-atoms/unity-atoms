# ⚛️ Unity Atoms
*Tiny modular pieces utilizing the power of Scriptable Objects*

## Influences
Unity Atoms is derrived from and a continuation of Ryan Hipple's [talk](https://www.youtube.com/watch?v=raQ3iHhE_Kk&t=2787s) from Unite 2017. The original source code can be found [here](https://github.com/roboryantron/Unite2017).

[This](https://www.youtube.com/watch?v=6vmRwLYWNRo&t=738s) talk by Richard Fine is a forerunner to Ryan Hipple's talk during Unite 2017.

## Motivation
The general approach to building scripts in Unity often generates a code base that is monolithic. This results in that your code is cumbersome to test, non-modular and hard to debug and understand.

Unity Atoms is an open source library that aims to make your game code become: 
- 📦 Modular *- avoid scripts and systems directly dependent on each other*
- ✏️ Editable *- Scriptable Objects makes it possible to make changes to your game at runtime*
- 🐞 Debuggable *- modular code is easier to debug than tightly coupled code*

## Introduction
Before you start looking into this library you should watch the video above ☝️ and read [this](https://unity3d.com/how-to/architect-with-scriptable-objects) article on how to architect your game with Scriptable Objects.

## Usage
Unity Atoms is an event based system that encourages the game to be as data-driven possible. At its core, the 4 most fundamental pieces (atoms) that are used are: 
- Variables
- (Game) Events
- (Game Event) Listeners
- Responses

### Variables 
Variables are data / variables stored as Scriptable Objects. Because they Variables are stored as Scriptable Objects they are not part of any scene, but could be more seen as part of a global shared game state. Variables are also designed to make it easy to inject (via the Unity Inspector) to your MonoBehaviours. Unity Atoms also offer some variations / additions to Variables such as Contants, References and Lists.

#### Constants
TODO 

#### References
TODO

#### Lists
TODO

### Game Events 
An event is a thing that happens that others could listen / subscribe to. Events are also Scriptable Objects that lives outside of a specific scene.

### Listeners 
A listener listens / observes / subscribes to an event and raises / invokes zero to many responses to that event. Listeners are Monobehaviours and lives in a scene.

### Responses 
Responses are usually, but not always, raised by a listener in response to an event. Responses can live both in the scene as [UnityEvents](https://docs.unity3d.com/ScriptReference/Events.UnityEvent.html) or outside the scene as a Scriptable Object in the shape of a Game Action or a Game Function.

#### Game Actions
TODO

#### Game Functions
TODO

### Mono Hooks
Mono Hooks is a way to make it possible to have Unity lifecycle methods as events instead. The main reason for this is to make the pattern consistent and possible to use in ALL of your code. 

## Further Notes
When you start thinking about this pattern you will realize that everything can be explained using the atoms above. The native Unity lifecycle methods can be thought of as variation of the pattern above, where events gets raised and passes a long data (eg. OnTriggerEnter2D) and you write a response to that event. 

## Examples
See the examples in the project.