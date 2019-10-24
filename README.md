# ⚛️ Unity Atoms

_Tiny modular pieces utilizing the power of Scriptable Objects_

## Influences

Unity Atoms is derrived from and a continuation of Ryan Hipple's [talk](https://www.youtube.com/watch?v=raQ3iHhE_Kk&t=2787s) from Unite 2017. The original source code can be found [here](https://github.com/roboryantron/Unite2017).

[This](https://www.youtube.com/watch?v=6vmRwLYWNRo&t=738s) talk by Richard Fine is a forerunner to Ryan Hipple's talk during Unite 2016.

## Motivation

The general approach to building scripts in Unity often generates a code base that is monolithic. This results in that your code is cumbersome to test, non-modular and hard to debug and understand.

Unity Atoms is an open source library that aims to make your game code:

-   📦 Modular _- avoid scripts and systems directly dependent on each other_
-   ✏️ Editable _- Scriptable Objects makes it possible to make changes to your game at runtime_
-   🐛 Debuggable _- modular code is easier to debug than tightly coupled code_

## Installation

_Prerequisite: Since Unity Atoms is using the Unity Package Manager (UPM) you need to use Unity version 2018.3 >=_

Add the following to your `manifest.json`:

```
{
    "scopedRegistries": [
        {
            "name": "NPM Registry",
            "url": "https://registry.npmjs.org",
            "scopes": [
                "com.mambojambostudios.unity-atoms-core",
                "com.mambojambostudios.unity-atoms-mobile",
                "com.mambojambostudios.unity-atoms-mono-hooks",
                "com.mambojambostudios.unity-atoms-tags",
                "com.mambojambostudios.unity-atoms-scene-mgmt",
                "com.mambojambostudios.unity-atoms-ui"
            ]
        }
    ],
    "dependencies": {
        ...
        "com.mambojambostudios.unity-atoms-core": "2.0.0",
        "com.mambojambostudios.unity-atoms-mobile": "2.0.0",
        "com.mambojambostudios.unity-atoms-mono-hooks": "2.0.0",
        "com.mambojambostudios.unity-atoms-tags": "2.0.0",
        "com.mambojambostudios.unity-atoms-scene-mgmt": "2.0.0",
        "com.mambojambostudios.unity-atoms-ui": "2.0.0",
        ...
    }
}
```

Note that the core package is mandatory while the others are optional. If you don't want a subpackage, simply remove it from your `dependencies`.

## Documentation

The Unity Atoms docs are now published at **https://adamramberg.github.io/unity-atoms**.

## How does it work?

Read [this](https://medium.com/@adamramberg/unity-atoms-tiny-modular-pieces-utilizing-the-power-of-scriptable-objects-e8add1b95201) article on Medium for a great introduction to Unity Atoms.

## Maintainers

-   [AdamRamberg](https://github.com/AdamRamberg)
-   [soraphis](https://github.com/soraphis)

We are looking for more people to join the team! Contact us if you want to jump aboard.
