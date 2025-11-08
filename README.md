<h1 align="center">  
 ⚛️ Unity Atoms
</h1>
<h3 align="center">  
 Scriptable Object Architecture
</h3>

---

<p align="center">
<i>Tiny modular pieces utilizing the power of Scriptable Objects</i><br/>
Inspired of Ryan Hipple's <a href="https://www.youtube.com/watch?v=raQ3iHhE_Kk&t=2787s">talk</a> from Unite 2017 this project features a set of tiny composible "Atoms" that improve modularity in your project. 
</p>

<p align="center">
  <a href="motivation">Motivation</a> •
  <a href="#installation">Installation</a> •
  <a href="https://unity-atoms.github.io/unity-atoms">Documentation</a> •
  <a href="https://discord.gg/W4yd7E7">Discord</a> •
  <a href="#aknowlegements">Aknowlegements</a> •
</p>


## Motivation

The general approach to building scripts in Unity often generates a code base that is monolithic. This results in that your code is cumbersome to test, non-modular and hard to debug and understand.

Unity Atoms is an open source library that aims to make your game code:

-   📦 Modular _- avoid scripts and systems directly dependent on each other_
-   ✏️ Editable _- Scriptable Objects makes it possible to make changes to your game at runtime_
-   🐛 Debuggable _- modular code is easier to debug than tightly coupled code_

... more in our <a href="https://unity-atoms.github.io/unity-atoms/docs/introduction/philosophy">Documentation</a>


# Installation

### Requirements

- Unity 2022.2+

### Github Link

In the Package manager window, add a package via git url:

```
    https://github.com/unity-atoms/unity-atoms.git#v4.5.0
```

<details>
<summary><h3>NPM</h3></summary>

Add the following to your `manifest.json` (which is located under your project location in the folder `Packages`):

```
{
    "scopedRegistries": [
        {
            "name": "NPM Registry",
            "url": "https://registry.npmjs.org",
            "scopes": [
                "com.unity-atoms.unity-atoms-core",
                "com.unity-atoms.unity-atoms-base-atoms",
                "com.unity-atoms.unity-atoms-fsm",
                "com.unity-atoms.unity-atoms-mobile",
                "com.unity-atoms.unity-atoms-mono-hooks",
                "com.unity-atoms.unity-atoms-tags",
                "com.unity-atoms.unity-atoms-scene-mgmt",
                "com.unity-atoms.unity-atoms-ui",
		        "com.unity-atoms.unity-atoms-input-system"
            ]
        }
    ],
    "dependencies": {
        ...
        "com.unity-atoms.unity-atoms-core": "4.5.0",
        "com.unity-atoms.unity-atoms-base-atoms": "4.5.0",
        "com.unity-atoms.unity-atoms-fsm": "4.5.0",
        "com.unity-atoms.unity-atoms-mobile": "4.5.0",
        "com.unity-atoms.unity-atoms-mono-hooks": "4.5.0",
        "com.unity-atoms.unity-atoms-tags": "4.5.0",
        "com.unity-atoms.unity-atoms-scene-mgmt": "4.5.0",
        "com.unity-atoms.unity-atoms-ui": "4.5.0",
	    "com.unity-atoms.unity-atoms-input-system": "4.5.0",
        ...
    }
}
```

Note that the core and base atoms packages are mandatory while the others are optional. If you don't want a subpackage, simply remove it from your `dependencies`.
Note that subpackages may have additional dependencies.

</details>

<details>
<summary><h3>OpenUPM</h3></summary>
    
[![openupm](https://img.shields.io/npm/v/com.unity-atoms.unity-atoms-core?label=core&registry_uri=https://package.openupm.com)](https://openupm.com/packages/com.unity-atoms.unity-atoms-core/)
[![openupm](https://img.shields.io/npm/v/com.unity-atoms.unity-atoms-base-atoms?label=base-atoms&registry_uri=https://package.openupm.com)](https://openupm.com/packages/com.unity-atoms.unity-atoms-base-atoms/)
[![openupm](https://img.shields.io/npm/v/com.unity-atoms.unity-atoms-fsm?label=fsm&registry_uri=https://package.openupm.com)](https://openupm.com/packages/com.unity-atoms.unity-atoms-fsm/)
[![openupm](https://img.shields.io/npm/v/com.unity-atoms.unity-atoms-mobile?label=mobile&registry_uri=https://package.openupm.com)](https://openupm.com/packages/com.unity-atoms.unity-atoms-mobile/)
[![openupm](https://img.shields.io/npm/v/com.unity-atoms.unity-atoms-mono-hooks?label=mono-hooks&registry_uri=https://package.openupm.com)](https://openupm.com/packages/com.unity-atoms.unity-atoms-mono-hooks/)
[![openupm](https://img.shields.io/npm/v/com.unity-atoms.unity-atoms-tags?label=tags&registry_uri=https://package.openupm.com)](https://openupm.com/packages/com.unity-atoms.unity-atoms-tags/)
[![openupm](https://img.shields.io/npm/v/com.unity-atoms.unity-atoms-scene-mgmt?label=scene-mgmt&registry_uri=https://package.openupm.com)](https://openupm.com/packages/com.unity-atoms.unity-atoms-scene-mgmt/)
[![openupm](https://img.shields.io/npm/v/com.unity-atoms.unity-atoms-ui?label=ui&registry_uri=https://package.openupm.com)](https://openupm.com/packages/com.unity-atoms.unity-atoms-ui/)
[![openupm](https://img.shields.io/npm/v/com.unity-atoms.unity-atoms-input-system?label=input-system&registry_uri=https://package.openupm.com)](https://openupm.com/packages/com.unity-atoms.unity-atoms-input-system/)

The package is available on the [openupm registry](https://openupm.com). It's recommended to install it via [openupm-cli](https://github.com/openupm/openupm-cli).

```
# required
openupm add com.unity-atoms.unity-atoms-core
openupm add com.unity-atoms.unity-atoms-base-atoms

# optional
openupm add com.unity-atoms.unity-atoms-fsm
openupm add com.unity-atoms.unity-atoms-mobile
openupm add com.unity-atoms.unity-atoms-mono-hooks
openupm add com.unity-atoms.unity-atoms-tags
openupm add com.unity-atoms.unity-atoms-scene-mgmt
openupm add com.unity-atoms.unity-atoms-ui
openupm add com.unity-atoms.unity-atoms-input-system
```

</details>


## Blog posts

-   [Unity Atoms — Tiny modular pieces utilizing the power of Scriptable Objects](https://medium.com/@adamramberg/unity-atoms-tiny-modular-pieces-utilizing-the-power-of-scriptable-objects-e8add1b95201)
-   [Announcing Unity Atoms v2](https://medium.com/@adamramberg/announcing-unity-atoms-v2-1719ef3e587e)
-   [Unity Atoms v4 is out!](https://medium.com/@adamramberg/unity-atoms-v4-is-out-b15a37da49da)
-   How does it work? Read [this](https://medium.com/@adamramberg/unity-atoms-tiny-modular-pieces-utilizing-the-power-of-scriptable-objects-e8add1b95201) article on Medium for a great introduction to Unity Atoms.

# Aknowlegements

## Maintainers

-   [soraphis](https://github.com/soraphis) (active)
-   [AdamRamberg](https://github.com/AdamRamberg) (creator)
-   [miikalo](https://github.com/miikalo)
-   [ThimoDEV](https://github.com/ThimoDEV)

We are looking for more people to join the team! Contact us if you want to jump aboard.

## Influences

 - [Ryan Hipple's original repository](https://github.com/roboryantron/Unite2017)
 - [This](https://www.youtube.com/watch?v=6vmRwLYWNRo&t=738s) talk by Richard Fine
