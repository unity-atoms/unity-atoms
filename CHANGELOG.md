💥 = Breaking changes
🐛 = Bug fixes
📝 = Documentation
🏠 = Internal
🏃‍♀= Performance
💅 = Polish
🚀 = New feature

# [Unreleased]

-   <Fill in your change here>

# 2.0.0 (September 3, 2019)

The release notes were introduced halfway through the work with version `2.0.0`. The list below might therefore not me 100% complete.

## 💥 Breaking changes

-   The repo has been split up to 6 different packages: core, mobile, mono-hooks, scene-mgmt, tags and ui
-   Changed name on Atomic Tags to UA Tags.

## 📝 Documentation

-   New website launched - https://adamramberg.github.io/unity-atoms
-   Improved / added documentation (READMEs).
-   Automatic generation of API docs in markdown format from C# XML comments.

## 🏠 Internal

-   Added internal tool to regenerate all existing Atoms. Nifty when doing changes that requires you to update all types of Atoms.

## 💅 Polish

-   Improved examples.

## 🚀 New features

-   Events can now be turned into IObservables making it possible to subscribe to them. this also makes Atoms compatible with UniRx.
-   None generic base classes for all atoms
-   Generator to generate new atoms with ease. Could be found under Tools / Unity Atoms / Generator.
-   Custom icons for all atoms.
-   Custom property drawers for all atoms.
-   Variables now discards play mode changes.
-   Public method `Reset` added to Variables.

# 1.0.0 (Mars 17, 2019)

-   Unity Atoms is now using UPM (Unity Package Manager) - see the README on the new and improved way to use and depend on Unity Atoms
-   Conditional Functions - Check a condition before executing an action.
-   Molecules - Larger constructs / sets of atoms and other ScriptableObjects. First Molecule added is the Timer.
-   Moved editor scripts to separate folder
-   Rearranged the structure of Unity Atoms. Scripts are now on the highest level separated on type (int, float, etc.) instead of on concept (Game Event, Variables, etc.). This seems like a more natural way of structuring the project and makes it easier for developers to include / exclude the relevant stuff for their project.
-   New type called TouchUserInput that keeps track of a user’s touch input. There is also a possibility to detect tap / double tap.
-   Added new MonoHooks, for example OnPointerDownHook, OnButtonClickHook, OnTriggerStay and OnTriggerEnter.
-   Added SetStringVariableValue
-   Added type Collider
-   Added UIContainer
-   AtomicTags - Use tags the Unity Atoms way.

# 1.0.0 Beta (December 12, 2018)

-   Conditional Functions -> Check a condition before executing an action.
-   Molecules - Larger constructs / sets of atoms and other ScriptableObjects. First Molecule added is the Timer.
-   Moved editor scripts to separate folder
-   Rearranged the structure of Unity Atoms. Scripts are now on the highest level separated on type (int, float, etc.) instead of on concept (Game Event, Variables, etc.). This seems like a more natural way of structuring the project and makes it easier for developers to include / exclude the relevant stuff for their project.
-   New type called TouchUserInput that keeps track of a user’s touch input. There is also a possibility to detect tap / double tap.
-   Added new MonoHooks. For example OnPointerDownHook, OnButtonClickHook, OnTriggerStay and OnTriggerEnter.
-   New types added.
-   Added SetStringVariableValue.

# 0.1.2 (November 30, 2018)

-   fileName and order of CreateAssetMenu for better usability - 181426f

# 0.1.1 (November 16, 2018)

-   Converted ColorVariable, Vector2Variable and Vector3Variable to ScriptableObjectVariable from EquatableScriptableObjectVariable. Before fix older versions of Unity complaint about issues with boxing conversion.

# 0.0.1 (November 13, 2018)

-   Initial release of Unity Atoms
