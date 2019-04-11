# Contributing
Thanks for considering contributing to Unity Atoms ❤️ Read the guidelines below before you submit an issue or create a PR. 

## Project structure
- Source - contains all the source code for the library
- UnityAtomsTestsAndExamples - this folder is a Unity project folder that contains examples and tests. This folder is not included in the distribution of Unity Atoms. 

The reason for this project structure is that we want to include tests and examples in the repo (both needing a Unity project), but there are at the same time currently some restrictions when using the UPM regarding how to import it to your project. 

### UPM doesn't allow... 
- importing a sub folder in a Git repo. 
- excluding files (using property "files" in package.json) when importing locally using the file syntax (eg. "com.mambojambostudios.unity-atoms-src": "file:../../Source"). 
- package.json in subdirectories (only root level)

### Current project structure therefore allows for... 
- including an example repo for examples and tests
- use the local source in the example repo
- referencing this git repo in another project's manifest file

## Style Guide

### Language Usage
* Mark closed types as sealed to enable proper devirtualization (see [here](https://blogs.unity3d.com/2016/07/26/il2cpp-optimizations-devirtualization/) for more info).
* Avoid LINQ usage for runtime usage except where absolutely possible (`ToList` or `ToArray` for example) and avoid using `ForEach`. Using these methods creates easily avoidable garbage. Editor usage is another story as performance is not as generally important.

### Layout
There is an `.editorconfig` at the root of the repository located [here](/.editorconfig) that can be used by most IDEs to help ensure these settings are automatically applied.
* **Indentation:** 1 tab = 4 spaces (no tab character)
* **Desired width:** 120-130 characters max per line
* **Line Endings:** Unix (LF), with a new-line at the end of each file.
* **White Space:** Trim empty whitespace from the ends of lines.

### Naming and Formatting
| Object Name | Notation | Example |
| ----------- | -------- | ------- |
| Namespaces | PascalCase | UnityAtoms |
| Classes | PascalCase | AtomicTags |
| Methods | PascalCase | GetTags |
| Method arguments | camelCase | oldValue |
| Properties | PascalCase | Value |
| Public fields | PascalCase | Value |
| Private fields | _camelCase | _value |
| Constants | SNAKE_CASE | NETWORK_ACCESS_TOKEN_SIZE |
| Inline variables | camelCase | value |

### Structure
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

### Example Formatting
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

## Pull requests
Pull requests should be made to the [canary branch](https://github.com/AdamRamberg/unity-atoms/tree/canary).
