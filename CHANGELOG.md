💥 = Breaking changes
🐛 = Bug fixes
📝 = Documentation
🏠 = Internal
🏃‍♀= Performance
💅 = Polish
🚀 = New features

# [Unreleased]

# 4.2.1 (June 22, 2020)

## 🐛 Bug fixes

-   Fixed clear button handler for StackTraces. ([@AdamRamberg](https://github.com/AdamRamberg)
-   Fixed and rearranged StackTraces compiler flags. ([@AdamRamberg](https://github.com/AdamRamberg)

# 4.2.0 (June 20, 2020)

## 🐛 Bug fixes

-   [#145](https://github.com/AdamRamberg/unity-atoms/pull/145) Removed duplicate check before adding an item to the list ([@mnarimani](https://github.com/mnarimani))
-   [#147](https://github.com/AdamRamberg/unity-atoms/pull/147) Fix code generation bug ([@AdamRamberg](https://github.com/AdamRamberg))
-   [#155](https://github.com/AdamRamberg/unity-atoms/pull/155) Fixing drawer for generated reference of complex struct type ([@bguyl](https://github.com/bguyl)
-   Fix bug where usage popup sometimes were hidden. ([@AdamRamberg](https://github.com/AdamRamberg))
-   [#160](https://github.com/AdamRamberg/unity-atoms/issues/160) Hook up OnFixedUpdate handler. ([@AdamRamberg](https://github.com/AdamRamberg))
-   [#164](https://github.com/AdamRamberg/unity-atoms/issues/164) Does not work in Unity 2018.3 ([@AdamRamberg](https://github.com/AdamRamberg))

## 📝 Documentation

-   [#152](https://github.com/AdamRamberg/unity-atoms/pull/152) Add the [Serializable] attribute in the doc ([@bguyl](https://github.com/bguyl)

## 🏠 Internal

-   Upgraded Example project to Unity version 2019.3.15f1. ([@AdamRamberg](https://github.com/AdamRamberg))
-   Add GetParent / GetValue extenstions for SerializedProperty. ([@AdamRamberg](https://github.com/AdamRamberg))

## 💅 Polish

-   [#128](https://github.com/AdamRamberg/unity-atoms/pull/128) Developer Description changed from Multiline to TextArea attribute ([@IceTrooper](https://github.com/IceTrooper))
-   [#140](https://github.com/AdamRamberg/unity-atoms/pull/140) Changes in GetEvent implementation to allow inheritance ([@soraphis](https://github.com/soraphis))

## 🚀 New features

-   [#125](https://github.com/AdamRamberg/unity-atoms/issues/125) Add booleans to decide if Changed and/or ChangedWithHistory Events are triggered on AtomVariable OnEnable ([@iruizmar](https://github.com/iruizmar))
-   [#157](https://github.com/AdamRamberg/unity-atoms/pull/157) Added forceEvent parameter for SetValue function on AtomVariable ([@AdamRamberg](https://github.com/AdamRamberg))
-   [#159](https://github.com/AdamRamberg/unity-atoms/pull/159) Debug events by displaying stack traces for events. ([@AdamRamberg](https://github.com/AdamRamberg))

# 4.1.0 (April 3, 2020)

## 💅 Polish

-   [#120](https://github.com/AdamRamberg/unity-atoms/pull/120) Fix typos ([@Enderlook](https://github.com/Enderlook))

## 🚀 New features

-   [#123](https://github.com/AdamRamberg/unity-atoms/pull/123) Add Event Refs for Collections and Lists. ([@AdamRamberg](https://github.com/AdamRamberg))

# 4.0.2 (March 21, 2020)

## 🐛 Bug fixes

-   Added missing assembly definition. ([@AdamRamberg](https://github.com/AdamRamberg))
-   Added missing meta. ([@AdamRamberg](https://github.com/AdamRamberg))

# 4.0.1 (March 21, 2020)

## 🐛 Bug fixes

-   Include Editor folder for FSM package. ([@AdamRamberg](https://github.com/AdamRamberg))

# 4.0.0 (March 21, 2020)

## 🐛 Bug fixes

-   Fixed a bug where it was not possible to change Variable value of Atoms of class type. ([@AdamRamberg](https://github.com/AdamRamberg))

## Documentation

-   General improvements to the documentation. ([@AdamRamberg](https://github.com/AdamRamberg))

## 🏠 Internal

-   💥 Changed With History Event is now an `AtomEvent<IPair<T>>` instead of an `AtomEvent<T, T>`. ([@AdamRamberg](https://github.com/AdamRamberg))
-   Sync to Collection / List is now moved from Variable Instancers to it's own script. ([@AdamRamberg](https://github.com/AdamRamberg))
-   New example scene: InfiniteWaves.
-   New package - Base Atoms. This is a mandatory package to use together with Core. However, breaking out the implementations from the Core makes the library easier to maintain. ([@AdamRamberg](https://github.com/AdamRamberg))

## 🚀 New features

-   New package - FSM 🎉 ([@AdamRamberg](https://github.com/AdamRamberg))
-   Added Collection and List Instancers. ([@AdamRamberg](https://github.com/AdamRamberg))
-   Added an `OnInitialization` function to `AtomTags`. ([@AdamRamberg](https://github.com/AdamRamberg))
-   New script for resetting Variables called `VariableResetter`. ([@AdamRamberg](https://github.com/AdamRamberg))
-   Added property id to Variables. ([@AdamRamberg](https://github.com/AdamRamberg))

# 3.0.0 (February 24, 2020)

## 🏠 Internal

-   [beb7405](https://github.com/AdamRamberg/unity-atoms/commit/beb740503c1cad86a200def6bf40897149b26340) - Updated Example project to 2019.3.1f1. ([@AdamRamberg](https://github.com/AdamRamberg))

## 🚀 New features

-   [#93](https://github.com/AdamRamberg/unity-atoms/pull/93) - Added pre change transformers to Variables + Clamp Int / Float. Pre Change Transformers makes it possible to add functions to Variables that gets executed when a Variable is about to get changed and that transforms the value in some way, eg. clamps an IntVariable between two values. ([@AdamRamberg](https://github.com/AdamRamberg))
-   [#110](https://github.com/AdamRamberg/unity-atoms/pull/110) - Added Variable Instancer, Event Reference, Atom Collection and Atom List (old Atom List renamed to Atom Value List). See docs. future blog post and PR for more information regarding these features. ([@AdamRamberg](https://github.com/AdamRamberg))
-   [#113](https://github.com/AdamRamberg/unity-atoms/pull/113) - Added constructor with value to Reference classes. ([@AdamRamberg](https://github.com/AdamRamberg))
-   [#114](https://github.com/AdamRamberg/unity-atoms/pull/114) - Added Replay functionality to Atom Events. ([@AdamRamberg](https://github.com/AdamRamberg))
-   [#115](https://github.com/AdamRamberg/unity-atoms/pull/115) - Add util actions to Variables. ([@AdamRamberg](https://github.com/AdamRamberg))

# 2.2.0 (February 23, 2020)

## 🐛 Bug fixes

-   [#106](https://github.com/AdamRamberg/unity-atoms/pull/111) - Reactivate Generator function in Unity 2018.4. ([@fakegood](https://github.com/fakegood), [@AdamRamberg](https://github.com/AdamRamberg))
-   [#109](https://github.com/AdamRamberg/unity-atoms/pull/108) - IsUnityAtomsRepo should never be settable. ([@AdamRamberg](https://github.com/AdamRamberg))
-   [#109](https://github.com/AdamRamberg/unity-atoms/pull/109) - Fix indentation bug in variable drawer. ([@AdamRamberg](https://github.com/AdamRamberg))
-   [#111](https://github.com/AdamRamberg/unity-atoms/pull/111) - Variables are now equal by reference instead of being equal by value. Should maybe been part of a major release because it is technically an API breaking changes, but considered a bug so instead bumping minior. ([@AdamRamberg](https://github.com/AdamRamberg))

# 2.1.1 (January 23, 2020)

## 🐛 Bug fixes

-   [#98](https://github.com/AdamRamberg/unity-atoms/pull/98) Unity v2018.4 Support. ([@fakegood](https://github.com/fakegood))
-   [#102](https://github.com/AdamRamberg/unity-atoms/pull/102) Fix Remove Tag from AtomTags and Fix Remove Tag Test . ([@lucasrferreira](https://github.com/lucasrferreira))

## 📝 Documentation

-   [#100](https://github.com/AdamRamberg/unity-atoms/pull/100) Added installation options and badges for OpenUPM. ([@favoyang](https://github.com/favoyang), [@AdamRamberg](https://github.com/AdamRamberg))

## 🏠 Internal

-   Update example project to Unity 2019.2.17f1

# 2.1.0 (November 28, 2019)

## 🐛 Bug fixes

-   [#91](https://github.com/AdamRamberg/unity-atoms/issues/91) Name OnTriggerHook class properly. ([@AdamRamberg](https://github.com/AdamRamberg))

## 📝 Documentation

-   [#73](https://github.com/AdamRamberg/unity-atoms/issues/73) Add discord link to docs. ([@AdamRamberg](https://github.com/AdamRamberg))
-   [#84](https://github.com/AdamRamberg/unity-atoms/pull/84) Changed AddComponentMenu names for Listeners/Hooks. ([@IceTrooper](https://github.com/IceTrooper))

## 🚀 New features

-   [#78](https://github.com/AdamRamberg/unity-atoms/pull/78) Setter to AtomReference's Value was added. ([@Saso222](https://github.com/Saso222), [@soraphis](https://github.com/soraphis))
-   [#86](https://github.com/AdamRamberg/unity-atoms/pull/86) Parameterless AtomListener and AtomEvent. ([@IceTrooper](https://github.com/IceTrooper), [@soraphis](https://github.com/soraphis))

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
