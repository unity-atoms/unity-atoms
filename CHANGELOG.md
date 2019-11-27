💥 = Breaking changes
🐛 = Bug fixes
📝 = Documentation
🏠 = Internal
🏃‍♀= Performance
💅 = Polish
🚀 = New features

# [Unreleased]

## 🐛 Bug fixes

-   [#91](https://github.com/AdamRamberg/unity-atoms/issues/91) Name OnTriggerHook class properly. ([@AdamRamberg](https://github.com/AdamRamberg))

## 📝 Documentation

-   [#73](https://github.com/AdamRamberg/unity-atoms/issues/73) Add discord link to docs. ([@AdamRamberg](https://github.com/AdamRamberg))
-   [#84](https://github.com/AdamRamberg/unity-atoms/pull/84) Changed AddComponentMenu names for Listeners/Hooks. ([@IceTrooper](https://github.com/IceTrooper))

## 🚀 New features

-   [#78](https://github.com/AdamRamberg/unity-atoms/pull/78) Setter to AtomReference's Value was added. ([@Saso222](https://github.com/Saso222), [@soraphis](https://github.com/soraphis))

## 💅 Polish

-   [#70](https://github.com/AdamRamberg/unity-atoms/pull/70) Better user guidance for working with AtomVariables. ([@soraphis](https://github.com/soraphis), [@AdamRamberg](https://github.com/AdamRamberg))
-   [#89](https://github.com/AdamRamberg/unity-atoms/pull/89) Variable and Constant Drawers show a preview value. ([@soraphis](https://github.com/soraphis), [@AdamRamberg](https://github.com/AdamRamberg))

# 2.0.0 (October 24, 2019)

_The release notes were introduced halfway through the work with version `2.0.0`. The list below might therefore not me 100% complete._

## 🐛 Bug fixes

-   Fix indent and ui state issues of the `AtomDrawer&lt;T&gt;`

## 💥 Breaking changes

-   The repo has been split up to 6 different packages: core, mobile, mono-hooks, scene-mgmt, tags and ui
-   Changed name on Atomic Tags to Atom Tags.

## 📝 Documentation

-   New website launched - https://adamramberg.github.io/unity-atoms
-   Improved / added documentation (READMEs).
-   Automatic generation of API docs in markdown format from C# XML comments.

## 🏠 Internal

-   Added internal tool to regenerate all existing Atoms. Nifty when doing changes that requires you to update all types of Atoms.
-   Removed all `FormerlySerializedAs` attributes.

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
