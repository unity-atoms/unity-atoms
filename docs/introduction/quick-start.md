---
id: quick-start
title: Quick start
hide_title: true
sidebar_label: Quick start
---

# Quick start

## Installation

_Prerequisite: Since Unity Atoms is using the Unity Package Manager (UPM) you need to use Unity version 2018.3 >=_

### NPM

Add the following to your `manifest.json`:

```
{
    "scopedRegistries": [
        {
            "name": "NPM Registry",
            "url": "https://registry.npmjs.org",
            "scopes": [
                "com.mambojambostudios.unity-atoms-core",
                "com.mambojambostudios.unity-atoms-base-atoms",
                "com.mambojambostudios.unity-atoms-fsm",
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
        "com.mambojambostudios.unity-atoms-core": "4.1.0",
        "com.mambojambostudios.unity-atoms-base-atoms": "4.1.0",
        "com.mambojambostudios.unity-atoms-fsm": "4.1.0",
        "com.mambojambostudios.unity-atoms-mobile": "4.1.0",
        "com.mambojambostudios.unity-atoms-mono-hooks": "4.1.0",
        "com.mambojambostudios.unity-atoms-tags": "4.1.0",
        "com.mambojambostudios.unity-atoms-scene-mgmt": "4.1.0",
        "com.mambojambostudios.unity-atoms-ui": "4.1.0",
        ...
    }
}
```

Note that the core and base atoms packages are mandatory while the others are optional. If you don't want a subpackage, simply remove it from your `dependencies`.

### OpenUPM

The package is available on the [openupm registry](https://openupm.com). It's recommended to install it via [openupm-cli](https://github.com/openupm/openupm-cli).

```
# required
openupm add com.mambojambostudios.unity-atoms-core
openupm add com.mambojambostudios.unity-atoms-base-atoms

# optional
openupm add com.mambojambostudios.unity-atoms-fsm
openupm add com.mambojambostudios.unity-atoms-mobile
openupm add com.mambojambostudios.unity-atoms-mono-hooks
openupm add com.mambojambostudios.unity-atoms-tags
openupm add com.mambojambostudios.unity-atoms-scene-mgmt
openupm add com.mambojambostudios.unity-atoms-ui
```

### Github URL

There is an alternative approach installing Unity Atoms using the Github URL to this repo.

Add the following to your `manifest.json`:

```
{
    "dependencies": {
        ...
        "com.mambojambostudios.unity-atoms": "https://github.com/AdamRamberg/unity-atoms.git#master",
        ...
    }
}
```

## Create your first Atom

You are now ready to create your first Atom. Simply right click somewhere in the Project window and go to **Create / Unity Atoms** and pick the Atom of your choice:

![create-your-first-atom](assets/create-your-first-atom.png)

Now you are ready to go to [Overview and philosopy](./overview.md) to learn more about Unity Atoms!
