💥 = Breaking changes
🐛 = Bug fixes
📝 = Documentation
🏠 = Internal
🏃‍♀= Performance
💅 = Polish
🚀 = New features

# 4.5.0 (December 19, 2023)

## 🐛 Bug fixes
- [#437](https://github.com/unity-atoms/unity-atoms/pull/437) Fixing a Rendering issue of QuaternionReferenceDrawer ([@soraphis](https://github.com/soraphis))
- [#447](https://github.com/unity-atoms/unity-atoms/pull/447) Fix value field height of Quaternions in reference drawer for older Unity versions ([@AdamRamberg](https://github.com/AdamRamberg))

## 🏃‍♀ Performance
- [#435](https://github.com/unity-atoms/unity-atoms/pull/435) Reduced debug overhead of Events ([@soraphis](https://github.com/soraphis))

## 🚀 New features
- [#440](https://github.com/unity-atoms/unity-atoms/pull/440) Auto drag and drop atom references through inspector without the need to manually switch usage type ([toasterhead-master](https://github.com/toasterhead-master))

# 4.4.8 (August 8, 2023)

## 🐛 Bug fixes
-   [#425](https://github.com/unity-atoms/unity-atoms/pull/425) Fix "The name '_instances' does not exist in the current context" ([@AdamRamberg](https://github.com/AdamRamberg))

# 4.4.7 (August 4, 2023)

## 🐛 Bug fixes
-   [#422](https://github.com/unity-atoms/unity-atoms/pull/422) make FSM compatible with disabled domain reload ([@soraphis](https://github.com/soraphis))
-   [#420](https://github.com/unity-atoms/unity-atoms/pull/420) AtomValueList disabled domain reload compatibility ([@soraphis](https://github.com/soraphis))
-   [#421](https://github.com/unity-atoms/unity-atoms/pull/421) Handling dead references when resetting objects ([@soraphis](https://github.com/soraphis) and [@AdamRamberg](https://github.com/AdamRamberg))

# 4.4.6 (July 22, 2023)

## 🐛 Bug fixes
-   [#359](https://github.com/unity-atoms/unity-atoms/pull/359) Vector2/3 reference not properly showing ([@soraphis](https://github.com/soraphis))
-   [#369](https://github.com/unity-atoms/unity-atoms/pull/369) Removed OnDisable method, to fix #349 ([@soraphis](https://github.com/soraphis))
-   [#364](https://github.com/unity-atoms/unity-atoms/pull/364) Fix: #363 enum property did not return int value, but index ([@soraphis](https://github.com/soraphis))
-   [#362](https://github.com/unity-atoms/unity-atoms/pull/362) Fix: corrected IEquatable implementation check ([@soraphis](https://github.com/soraphis))
-   [#371](https://github.com/unity-atoms/unity-atoms/pull/371) Prevent null reference exceptions in editor when using non-serializable types ([@soraphis](https://github.com/soraphis))
-   [#373](https://github.com/unity-atoms/unity-atoms/pull/373) Call base impl of ImplSpecificSetup() in FSM instancer ([@AdamRamberg](https://github.com/AdamRamberg))
-   [#386](https://github.com/unity-atoms/unity-atoms/pull/386) FiniteStateMachineMonoHook unload fix ([@soraphis](https://github.com/soraphis))
-   [#389](https://github.com/unity-atoms/unity-atoms/pull/389) Fixes syncgameobjecttolist adding object multiple times  ([@soraphis](https://github.com/soraphis))
-   [#409](https://github.com/unity-atoms/unity-atoms/pull/409) FIX: Using TextField in AssetGenerator does not work as expected ([@soraphis](https://github.com/soraphis))
-   [#403](https://github.com/unity-atoms/unity-atoms/pull/403) fix: Event Replay Buffer not cleared when domain reload disabled ([@soraphis](https://github.com/soraphis))

## 📝 Documentation
-   [#413](https://github.com/unity-atoms/unity-atoms/pull/413) Adding Documentation ([@soraphis](https://github.com/soraphis) and [@AdamRamberg](https://github.com/AdamRamberg))
-   [#411](https://github.com/unity-atoms/unity-atoms/pull/411) Remove generated API docs ([@AdamRamberg](https://github.com/AdamRamberg))

## 💅 Polish
-   [994026f](https://github.com/unity-atoms/unity-atoms/commit/994026fb7e74f0436c188f8e9c4e8050a4b2e639) Added input-system shield to README  ([@AdamRamberg](https://github.com/AdamRamberg))
-   [#317](https://github.com/unity-atoms/unity-atoms/pull/317) Set event name suggestion on Variable Changed event creation ([@ThimoDEV](https://github.com/ThimoDEV))

# 4.4.5 (May 9, 2022)

## 🐛 Bug fixes

-   [#348](https://github.com/unity-atoms/unity-atoms/pull/348) Fix conditional compilation for EDITOR only code that prevented building projects ([@soraphis](https://github.com/soraphis))

# 4.4.4 (April 17, 2022)

-   [@Casey-Hofland](https://github.com/Casey-Hofland) has left Unity Atoms as a maintainer. We wish Casey all the best and thank him for his contributions and help!
-   [@ThimoDEV](https://github.com/ThimoDEV) has joined as maintainer of Unity Atoms! 🥳

## 🐛 Bug fixes

-   [#340](https://github.com/unity-atoms/unity-atoms/pull/340) Fix NullReferenceException when Event Reference Listeners event reference is not set ([@ThimoDEV](https://github.com/ThimoDEV))
-   [#280](https://github.com/unity-atoms/unity-atoms/pull/289) Fix hasChildren display in AtomReferences ([@Casey-Hofland](https://github.com/Casey-Hofland))
-   [#270](https://github.com/unity-atoms/unity-atoms/pull/270) Fix ChangedOnOnEnable not triggered ([@simonbucher](https://github.com/simonbucher))
-   [#297](https://github.com/unity-atoms/unity-atoms/pull/297) Fix FiniteStateMachine not listening to Raise Event To Complete Transition ([@Kyrw](https://github.com/Kyrw))
-   [#306](https://github.com/unity-atoms/unity-atoms/pull/306) Fix in case no object was tagged FindByTag throwing an exception instead of returning null ([@soraphis](https://github.com/soraphis))
-   [#314](https://github.com/unity-atoms/unity-atoms/pull/314) Fix Drawer trying to create field for public Action ([@ThimoDEV](https://github.com/ThimoDEV))
-   [#309](https://github.com/unity-atoms/unity-atoms/pull/309) Fix the null check on Base events in AtomVariableInstancer not accounting for Base itself and not creating runtime AtomEvents ([@ThimoDEV](https://github.com/ThimoDEV))
-   [#310](https://github.com/unity-atoms/unity-atoms/pull/310) Fix void event instancer stopping working after a deactivate/activate cycle ([@ThimoDEV](https://github.com/ThimoDEV))
-   [#311](https://github.com/unity-atoms/unity-atoms/pull/311) Fix ulong variable throwing error when the value being edited in play mode ([@ThimoDEV](https://github.com/ThimoDEV))
-   [#312](https://github.com/unity-atoms/unity-atoms/pull/312) Remove duplicate definition of GameObjectGameObjectFunction in MonoHooks package ([@ThimoDEV](https://github.com/ThimoDEV))
-   [#313](https://github.com/unity-atoms/unity-atoms/pull/313) Fix default Changed and ChangedWithHistory events not created at runtime ([@ThimoDEV](https://github.com/ThimoDEV))
-   [#278](https://github.com/unity-atoms/unity-atoms/pull/278) Fix conditions not serializing in Unity 2019 ([@miikalo](https://github.com/miikalo))
-   [#300](https://github.com/unity-atoms/unity-atoms/pull/300) Fixed Serialization on AtomCollections. ([@Kyrw](https://github.com/Kyrw))

## 📝 Documentation

-   [#294](https://github.com/unity-atoms/unity-atoms/pull/294) Add missing scoped registry in install docs ([@ahSOLO](https://github.com/ahSOLO))
-   [#280](https://github.com/unity-atoms/unity-atoms/pull/280) Update link in UniRx tutorial ([@miikalo](https://github.com/miikalo))
-   [#267](https://github.com/unity-atoms/unity-atoms/pull/267) Updated documentation and tutorials on the website for v4 ([@miikalo](https://github.com/miikalo))
-   A "Smooth Workflow" section has been added under the CONTRIBUTING.md to explain how one can easily start contributing to Atoms whilst working from inside Unity. This was an issue as the atoms repository is not naturally compatible with Unity. ([@Casey-Hofland](https://github.com/Casey-Hofland))

## 🏠 Internal

-   [#320](https://github.com/unity-atoms/unity-atoms/pull/320) Change private to protected in 'list' variable in AtomValueList ([@ThimoDEV](https://github.com/ThimoDEV))
## 🏃‍♀ Performance

-   [#329](https://github.com/unity-atoms/unity-atoms/pull/329) Fix unnecessary allocations when debug mode disabled ([@soraphis](https://github.com/soraphis))
-   [#276](https://github.com/unity-atoms/unity-atoms/issues/276) The AtomGenerator has been improved to take no longer than about a single reimport ([@Casey-Hofland](https://github.com/Casey-Hofland))

## 💅 Polish

-   [#284](https://github.com/unity-atoms/unity-atoms/pull/284) Fixed specifying package dependencies ([@lumpn](https://github.com/lumpn))

# 4.4.3 (March 7, 2021)

## 🐛 Bug fixes

-   [#241](https://github.com/unity-atoms/unity-atoms/pull/241) Value of a VariableInstancer in EditMode leads to NullRef. ([@soraphis](https://github.com/soraphis))
-   [#230](https://github.com/unity-atoms/unity-atoms/pull/230) Compatibility with dynamic assemblies and different namespace/class conditions. ([@soraphis](https://github.com/soraphis))

## 🏃‍♀ Performance

-   [#238](https://github.com/unity-atoms/unity-atoms/pull/238) Lazy stacktrace toString conversion. ([@soraphis](https://github.com/soraphis))

## 💅 Polish

-   [#229](https://github.com/unity-atoms/unity-atoms/pull/229) Create button ease of use ([@Casey-Hofland](https://github.com/Casey-Hofland))

# 4.4.2 (December 30, 2020)

## 🐛 Bug fixes

-   Fixed ValueEquals for EquatableAtomVariable and EquatableAtomReference, which before the change caused a bug in AtomCollection. [@AdamRamberg](https://github.com/AdamRamberg)

# 4.4.1 (December 30, 2020)

## 🐛 Bug fixes

-   [#224](https://github.com/AdamRamberg/unity-atoms/issues/224) Move Atoms Search back to its own sub menu. Having same sub path for both MenuItem and CreateAssetMenu is causing the menu to be removed. [@AdamRamberg](https://github.com/AdamRamberg)

# 4.4.0 (December 30, 2020)

-   [@miikalo](https://github.com/miikalo) has joined as maintainer of Unity Atoms! 🥳

## 🐛 Bug fixes

-   [#201](https://github.com/AdamRamberg/unity-atoms/pull/201) UnregisterAll in AtomEvent does not seem to work ([@soraphis](https://github.com/soraphis))
-   [#199](https://github.com/AdamRamberg/unity-atoms/pull/199) Null Reference Exceptions when trying to set VoidBaseEventReferenceListener event in code ([@soraphis](https://github.com/soraphis))
-   [#216](https://github.com/AdamRamberg/unity-atoms/pull/216) Conditions created do not appear under Atoms Search [@AdamRamberg](https://github.com/AdamRamberg)
-   [#218](https://github.com/AdamRamberg/unity-atoms/pull/218) Fixing SerializedDictionary Memory Leak [@AdamRamberg](https://github.com/AdamRamberg)
-   [#219](https://github.com/AdamRamberg/unity-atoms/pull/219) Fixing FSM instancer where \_base always is null [@AdamRamberg](https://github.com/AdamRamberg)
-   [#220](https://github.com/AdamRamberg/unity-atoms/pull/220) Trigger initial events for instancers [@AdamRamberg](https://github.com/AdamRamberg)

## 📝 Documentation

-   [#190](https://github.com/AdamRamberg/unity-atoms/pull/190) Restructure tutorials and add two new tutorials ([@miikalo](https://github.com/miikalo))
-   [#193](https://github.com/AdamRamberg/unity-atoms/pull/193) Adding a little bit of clarity to installation ([@mutmedia](https://github.com/mutmedia)
-   [#207](https://github.com/AdamRamberg/unity-atoms/pull/207) Add FAQ to documentation pages ([@miikalo](https://github.com/miikalo))
-   [#206](https://github.com/AdamRamberg/unity-atoms/pull/206) Add tutorial for Conditions ([@miikalo](https://github.com/miikalo))

## 💅 Polish

-   [#217](https://github.com/AdamRamberg/unity-atoms/pull/217) Move "Atoms Search" under "Unity Atoms" in the "Create" context menu [@AdamRamberg](https://github.com/AdamRamberg))

## 🚀 New features

-   [#186](https://github.com/AdamRamberg/unity-atoms/pull/186) Searchable menu for faster atom creation ([@soraphis](https://github.com/soraphis))
-   [#182](https://github.com/AdamRamberg/unity-atoms/pull/182) Add workaround for "Enter Play Mode" feature to enable initial values ([@hazarartuner](https://github.com/hazarartuner))
-   [#187](https://github.com/AdamRamberg/unity-atoms/pull/187) Asset based atoms generation ([@soraphis](https://github.com/soraphis))
-   [#191](https://github.com/AdamRamberg/unity-atoms/pull/191) Basic implementation of conditions for listeners ([@miikalo](https://github.com/miikalo))
-   [#202](https://github.com/AdamRamberg/unity-atoms/pull/202) Added for AtomReference a check to see if an Atom is actually assigned ([@soraphis](https://github.com/soraphis))
-   [#212](https://github.com/AdamRamberg/unity-atoms/pull/212) Unity Atoms Input System Integration ([@Casey-Hofland](https://github.com/Casey-Hofland))
-   [#221](https://github.com/AdamRamberg/unity-atoms/pull/221) Add OnCollisionHook and OnCollision2DHook ([@Casey-Hofland](https://github.com/Casey-Hofland))

# 4.3.0 (August 4, 2020)

## 🐛 Bug fixes

-   [#168](https://github.com/AdamRamberg/unity-atoms/pull/168) Make IsUnityAtomsRepo OS agnostic ([@jmacgill](https://github.com/jmacgill))
-   [#174](https://github.com/AdamRamberg/unity-atoms/pull/174) Update AtomBaseReferenceDrawer.cs ([@soraphis](https://github.com/soraphis))
-   [#178](https://github.com/AdamRamberg/unity-atoms/pull/178) Fix Sub FSM Value issue ([@TriangularCube](https://github.com/TriangularCube))

## 🚀 New features

-   [#172](https://github.com/AdamRamberg/unity-atoms/pull/172) Instancer improvements. Adds the possibility to raise events from Event Instancers from the editor + makes base events none mandatory for Event Instancers. ([@mutmedia](https://github.com/mutmedia))
-   [#179](https://github.com/AdamRamberg/unity-atoms/pull/179) Add a default Event at runtime for Changed and ChangedWithHistory if not present. ([@mutmedia](https://github.com/mutmedia) and [@AdamRamberg](https://github.com/AdamRamberg))
-   [#180](https://github.com/AdamRamberg/unity-atoms/pull/180) Added option to clear Value List on OnEnable ([@mutmedia](https://github.com/mutmedia) and [@AdamRamberg](https://github.com/AdamRamberg))

## 🏠 Internal

[#169](https://github.com/AdamRamberg/unity-atoms/pull/169) Improvements to the internal templating engine used by the generator. ([@jmacgill](https://github.com/jmacgill))

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
