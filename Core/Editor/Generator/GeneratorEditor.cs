#if UNITY_2018_4_OR_NEWER
using System;
using System.Linq;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
#if UNITY_2019_1_OR_NEWER
using UnityEngine.UIElements;
#elif UNITY_2018_4_OR_NEWER
using UnityEditor.Experimental.UIElements;
using UnityEngine.Experimental.UIElements;
using UnityEngine.Experimental.UIElements.StyleEnums;
#endif

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Editor class for the `Generator`. Use it via the top window bar at _Tools / Unity Atoms / Generator_. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    public class GeneratorEditor : EditorWindow
    {
        private Generator generator;

        /// <summary>
        /// Create the editor window.
        /// </summary>
        [MenuItem("Tools/Unity Atoms/Generator")]
        static void Init()
        {
            var window = GetWindow<GeneratorEditor>(false, "Unity Atoms - Generator");
            window.position = new Rect(Screen.width / 2, Screen.height / 2, 440, 400);
            window.Show();
        }

        private string _type = "";
        private bool _isEquatable = true;
        private string _typeNamespace = "";
        private string _subUnityAtomsNamespace = "";

        private List<AtomType> _atomTypesToGenerate = new List<AtomType>()
        {
            AtomTypes.ACTION,
            AtomTypes.ACTION_X2,
            AtomTypes.CONSTANT,
            AtomTypes.EVENT,
            AtomTypes.EVENT_X2,
            AtomTypes.VALUE_LIST,
            AtomTypes.LISTENER,
            AtomTypes.LISTENER_X2,
            AtomTypes.REFERENCE,
            AtomTypes.SET_VARIABLE_VALUE,
            AtomTypes.UNITY_EVENT,
            AtomTypes.UNITY_EVENT_X2,
            AtomTypes.VARIABLE,
            AtomTypes.FUNCTION_X2,
            AtomTypes.VARIABLE_INSTANCER,
            AtomTypes.EVENT_REFERENCE,
            AtomTypes.EVENT_X2_REFERENCE
        };
        private Dictionary<AtomType, VisualElement> _typeVEDict = new Dictionary<AtomType, VisualElement>();
        private VisualElement _typesToGenerateInfoRow;

        private Dictionary<AtomType, List<AtomType>> _dependencies = new Dictionary<AtomType, List<AtomType>>() {
            { AtomTypes.VALUE_LIST, new List<AtomType>() { AtomTypes.EVENT } },
            { AtomTypes.LISTENER, new List<AtomType>() { AtomTypes.ACTION, AtomTypes.VARIABLE, AtomTypes.EVENT, AtomTypes.EVENT_X2, AtomTypes.FUNCTION_X2, AtomTypes.VARIABLE_INSTANCER, AtomTypes.EVENT_REFERENCE, AtomTypes.UNITY_EVENT } },
            { AtomTypes.LISTENER_X2, new List<AtomType>() { AtomTypes.ACTION_X2, AtomTypes.VARIABLE, AtomTypes.EVENT, AtomTypes.EVENT_X2, AtomTypes.FUNCTION_X2, AtomTypes.VARIABLE_INSTANCER, AtomTypes.EVENT_X2_REFERENCE, AtomTypes.UNITY_EVENT_X2 } },
            { AtomTypes.REFERENCE, new List<AtomType>() { AtomTypes.CONSTANT, AtomTypes.VARIABLE, AtomTypes.EVENT, AtomTypes.EVENT_X2, AtomTypes.FUNCTION_X2, AtomTypes.VARIABLE_INSTANCER } },
            { AtomTypes.SET_VARIABLE_VALUE, new List<AtomType>() { AtomTypes.EVENT, AtomTypes.EVENT_X2, AtomTypes.FUNCTION_X2, AtomTypes.VARIABLE, AtomTypes.CONSTANT, AtomTypes.REFERENCE, AtomTypes.VARIABLE_INSTANCER } },
            { AtomTypes.VARIABLE, new List<AtomType>() { AtomTypes.EVENT, AtomTypes.EVENT_X2, AtomTypes.FUNCTION_X2 } },
            { AtomTypes.VARIABLE_INSTANCER, new List<AtomType>() { AtomTypes.VARIABLE, AtomTypes.EVENT, AtomTypes.EVENT_X2, AtomTypes.FUNCTION_X2 } },
            { AtomTypes.EVENT_REFERENCE, new List<AtomType>() { AtomTypes.VARIABLE, AtomTypes.EVENT, AtomTypes.EVENT_X2, AtomTypes.FUNCTION_X2, AtomTypes.VARIABLE_INSTANCER } },
            { AtomTypes.EVENT_X2_REFERENCE, new List<AtomType>() { AtomTypes.VARIABLE, AtomTypes.EVENT, AtomTypes.EVENT_X2, AtomTypes.FUNCTION_X2, AtomTypes.VARIABLE_INSTANCER } }
        };

        /// <summary>
        /// Add provided `AtomType` to the list of Atom types to be generated.
        /// </summary>
        /// <param name="atomType">The `AtomType` to be added.</param>
        private void AddAtomTypeToGenerate(AtomType atomType)
        {
            _atomTypesToGenerate.Add(atomType);

            foreach (KeyValuePair<AtomType, List<AtomType>> entry in _dependencies)
            {
                if (entry.Value.All((atom) => _atomTypesToGenerate.Contains(atom)))
                {
                    _typeVEDict[entry.Key].SetEnabled(true);
                }
            }

            _typesToGenerateInfoRow.Query<Label>().First().text = "";
        }

        /// <summary>
        /// Remove provided `AtomType` from the list of Atom types to be generated.
        /// </summary>
        /// <param name="atomType">The `AtomType` to be removed.</param>
        private List<AtomType> RemoveAtomTypeToGenerate(AtomType atomType)
        {
            _atomTypesToGenerate.Remove(atomType);
            List<AtomType> disabledDeps = new List<AtomType>();

            foreach (KeyValuePair<AtomType, List<AtomType>> entry in _dependencies)
            {
                if (_atomTypesToGenerate.Contains(entry.Key) && entry.Value.Any((atom) => !_atomTypesToGenerate.Contains(atom)))
                {
                    _typeVEDict[entry.Key].SetEnabled(false);
                    var toggle = _typeVEDict[entry.Key].Query<Toggle>().First();
                    toggle.SetValueWithoutNotify(false);
                    toggle.MarkDirtyRepaint();
                    disabledDeps.Add(entry.Key);
                    disabledDeps = disabledDeps.Concat(RemoveAtomTypeToGenerate(entry.Key)).ToList();
                }
            }

            return disabledDeps;
        }

        /// <summary>
        /// Set and display warning text in the editor.
        /// </summary>
        /// <param name="atomType">`AtomType` to generate the warning for.</param>
        /// <param name="dependencies">The `AtomType`s that this `AtomType` is depending on.</param>
        private void SetWarningText(AtomType atomType, List<AtomType> dependencies = null)
        {
            if (dependencies != null && dependencies.Count > 0)
            {
                string warningText = $"{String.Join(", ", dependencies.Select((a) => a.DisplayName))} depend(s) on {atomType.DisplayName}.";
                _typesToGenerateInfoRow.Query<Label>().First().text = warningText;
            }
            else
            {
                _typesToGenerateInfoRow.Query<Label>().First().text = "";
            }
        }

        private static string _writePath = Runtime.IsUnityAtomsRepo
            ? "../Packages/Core" : "Assets/Atoms";

        /// <summary>
        /// Called when editor is enabled.
        /// </summary>
        private void OnEnable()
        {
            _atomTypesToGenerate = new List<AtomType>()
            {
                AtomTypes.ACTION,
                AtomTypes.ACTION_X2,
                AtomTypes.CONSTANT,
                AtomTypes.EVENT,
                AtomTypes.EVENT_X2,
                AtomTypes.VALUE_LIST,
                AtomTypes.LISTENER,
                AtomTypes.LISTENER_X2,
                AtomTypes.REFERENCE,
                AtomTypes.SET_VARIABLE_VALUE,
                AtomTypes.UNITY_EVENT,
                AtomTypes.UNITY_EVENT_X2,
                AtomTypes.VARIABLE,
                AtomTypes.FUNCTION_X2,
                AtomTypes.VARIABLE_INSTANCER,
                AtomTypes.EVENT_REFERENCE,
                AtomTypes.EVENT_X2_REFERENCE
            };
            generator = generator == null ? new Generator() : generator;
#if UNITY_2019_1_OR_NEWER
            var root = this.rootVisualElement;
#elif UNITY_2018_4_OR_NEWER
            var root = this.GetRootVisualContainer();
#endif
            var pathRow = new VisualElement() { style = { flexDirection = FlexDirection.Row } };
            pathRow.Add(new Label() { text = "Relative Write Path", style = { width = 180, marginRight = 8 } });
            var textfield = new TextField() { value = _writePath, style = { flexGrow = 1 } };
            textfield.RegisterCallback<ChangeEvent<string>>(evt => _writePath = evt.newValue);
            pathRow.Add(textfield);
            root.Add(pathRow);

            var typeNameRow = new VisualElement() { style = { flexDirection = FlexDirection.Row } };
            typeNameRow.Add(new Label() { text = "Type Name", style = { width = 180, marginRight = 8 } });
            textfield = new TextField() { value = _type, style = { flexGrow = 1 } };
            textfield.RegisterCallback<ChangeEvent<string>>(evt => _type = evt.newValue);
            typeNameRow.Add(textfield);
            root.Add(typeNameRow);

            var equatableRow = new VisualElement() { style = { flexDirection = FlexDirection.Row } };
            equatableRow.Add(new Label() { text = "Is Type Equatable?", style = { width = 180, marginRight = 8 } });
            var equatableToggle = new Toggle() { value = _isEquatable, style = { flexGrow = 1 } };
            equatableToggle.RegisterCallback<ChangeEvent<bool>>(evt => _isEquatable = evt.newValue);
            equatableRow.Add(equatableToggle);
            root.Add(equatableRow);

            var typeNamespaceRow = new VisualElement() { style = { flexDirection = FlexDirection.Row } };
            typeNamespaceRow.Add(new Label() { text = "Type Namespace", style = { width = 180, marginRight = 8 } });
            textfield = new TextField() { value = _typeNamespace, style = { flexGrow = 1 } };
            textfield.RegisterCallback<ChangeEvent<string>>(evt => _typeNamespace = evt.newValue);
            typeNamespaceRow.Add(textfield);
            root.Add(typeNamespaceRow);

            var subUnityAtomsNamespaceRow = new VisualElement() { style = { flexDirection = FlexDirection.Row } };
            subUnityAtomsNamespaceRow.Add(new Label() { text = "Sub Unity Atoms Namespace", style = { width = 180, marginRight = 8 } });
            textfield = new TextField() { value = _subUnityAtomsNamespace, style = { flexGrow = 1 } };
            textfield.RegisterCallback<ChangeEvent<string>>(evt => _subUnityAtomsNamespace = evt.newValue);
            subUnityAtomsNamespaceRow.Add(textfield);
            root.Add(subUnityAtomsNamespaceRow);

            root.Add(CreateDivider());

            var typesToGenerateLabelRow = new VisualElement() { style = { flexDirection = FlexDirection.Row } };
            typesToGenerateLabelRow.Add(new Label() { text = "Type(s) to Generate" });
            root.Add(typesToGenerateLabelRow);

            _typeVEDict.Add(AtomTypes.ACTION, CreateAtomTypeToGenerateToggleRow(AtomTypes.ACTION));
            root.Add(_typeVEDict[AtomTypes.ACTION]);
            _typeVEDict.Add(AtomTypes.ACTION_X2, CreateAtomTypeToGenerateToggleRow(AtomTypes.ACTION_X2));
            root.Add(_typeVEDict[AtomTypes.ACTION_X2]);
            _typeVEDict.Add(AtomTypes.CONSTANT, CreateAtomTypeToGenerateToggleRow(AtomTypes.CONSTANT));
            root.Add(_typeVEDict[AtomTypes.CONSTANT]);
            _typeVEDict.Add(AtomTypes.EVENT, CreateAtomTypeToGenerateToggleRow(AtomTypes.EVENT));
            root.Add(_typeVEDict[AtomTypes.EVENT]);
            _typeVEDict.Add(AtomTypes.EVENT_X2, CreateAtomTypeToGenerateToggleRow(AtomTypes.EVENT_X2));
            root.Add(_typeVEDict[AtomTypes.EVENT_X2]);
            _typeVEDict.Add(AtomTypes.VALUE_LIST, CreateAtomTypeToGenerateToggleRow(AtomTypes.VALUE_LIST));
            root.Add(_typeVEDict[AtomTypes.VALUE_LIST]);
            _typeVEDict.Add(AtomTypes.LISTENER, CreateAtomTypeToGenerateToggleRow(AtomTypes.LISTENER));
            root.Add(_typeVEDict[AtomTypes.LISTENER]);
            _typeVEDict.Add(AtomTypes.LISTENER_X2, CreateAtomTypeToGenerateToggleRow(AtomTypes.LISTENER_X2));
            root.Add(_typeVEDict[AtomTypes.LISTENER_X2]);
            _typeVEDict.Add(AtomTypes.REFERENCE, CreateAtomTypeToGenerateToggleRow(AtomTypes.REFERENCE));
            root.Add(_typeVEDict[AtomTypes.REFERENCE]);
            _typeVEDict.Add(AtomTypes.SET_VARIABLE_VALUE, CreateAtomTypeToGenerateToggleRow(AtomTypes.SET_VARIABLE_VALUE));
            root.Add(_typeVEDict[AtomTypes.SET_VARIABLE_VALUE]);
            _typeVEDict.Add(AtomTypes.UNITY_EVENT, CreateAtomTypeToGenerateToggleRow(AtomTypes.UNITY_EVENT));
            root.Add(_typeVEDict[AtomTypes.UNITY_EVENT]);
            _typeVEDict.Add(AtomTypes.UNITY_EVENT_X2, CreateAtomTypeToGenerateToggleRow(AtomTypes.UNITY_EVENT_X2));
            root.Add(_typeVEDict[AtomTypes.UNITY_EVENT_X2]);
            _typeVEDict.Add(AtomTypes.VARIABLE, CreateAtomTypeToGenerateToggleRow(AtomTypes.VARIABLE));
            root.Add(_typeVEDict[AtomTypes.VARIABLE]);
            _typeVEDict.Add(AtomTypes.FUNCTION_X2, CreateAtomTypeToGenerateToggleRow(AtomTypes.FUNCTION_X2));
            root.Add(_typeVEDict[AtomTypes.FUNCTION_X2]);
            _typeVEDict.Add(AtomTypes.VARIABLE_INSTANCER, CreateAtomTypeToGenerateToggleRow(AtomTypes.VARIABLE_INSTANCER));
            root.Add(_typeVEDict[AtomTypes.VARIABLE_INSTANCER]);
            _typeVEDict.Add(AtomTypes.EVENT_REFERENCE, CreateAtomTypeToGenerateToggleRow(AtomTypes.EVENT_REFERENCE));
            root.Add(_typeVEDict[AtomTypes.EVENT_REFERENCE]);
            _typeVEDict.Add(AtomTypes.EVENT_X2_REFERENCE, CreateAtomTypeToGenerateToggleRow(AtomTypes.EVENT_X2_REFERENCE));
            root.Add(_typeVEDict[AtomTypes.EVENT_X2_REFERENCE]);

            root.Add(CreateDivider());

            _typesToGenerateInfoRow = new VisualElement() { style = { flexDirection = FlexDirection.Column } };
            _typesToGenerateInfoRow.Add(new Label() { style = { color = Color.yellow, height = 12 } });
            _typesToGenerateInfoRow.RegisterCallback<MouseUpEvent>((e) => { _typesToGenerateInfoRow.Query<Label>().First().text = ""; });
            root.Add(_typesToGenerateInfoRow);

            root.Add(CreateDivider());

            var buttonRow = new VisualElement()
            {
                style = { flexDirection = FlexDirection.Row }
            };
            var button1 = new Button(Close)
            {
                text = "Close",
                style = { flexGrow = 1 }
            };
            buttonRow.Add(button1);

            var button2 = new Button(() => generator.Generate(
                type: _type,
                baseWritePath: _writePath,
                isEquatable: _isEquatable,
                atomTypesToGenerate: _atomTypesToGenerate,
                typeNamespace: _typeNamespace,
                subUnityAtomsNamespace: _subUnityAtomsNamespace
            ))
            {
                text = "Generate",
                style = { flexGrow = 1 }
            };
            buttonRow.Add(button2);
            root.Add(buttonRow);
        }

        /// <summary>
        /// Helper method to create a divider.
        /// </summary>
        /// <returns>The divider (`VisualElement`) created.</returns>
        private VisualElement CreateDivider()
        {
            return new VisualElement()
            {
                style = { flexDirection = FlexDirection.Row, marginBottom = 2, marginTop = 2, marginLeft = 2, marginRight = 2, height = 1 }
            };
        }

        /// <summary>
        /// Helper to create toogle row for a specific `AtomType`.
        /// </summary>
        /// <param name="atomType">The provided `AtomType`.</param>
        /// <returns>A new toggle row (`VisualElement`).</returns>
        private VisualElement CreateAtomTypeToGenerateToggleRow(AtomType atomType)
        {
            var row = new VisualElement() { style = { flexDirection = FlexDirection.Row } };
            row.Add(new Label() { text = atomType.DisplayName, style = { width = 180, marginRight = 8 } });
            var toggle = new Toggle() { value = _atomTypesToGenerate.Contains(atomType) };
            toggle.RegisterCallback<ChangeEvent<bool>>(evt =>
            {
                if (evt.newValue)
                {
                    AddAtomTypeToGenerate(atomType);
                }
                else
                {
                    var disabledDeps = RemoveAtomTypeToGenerate(atomType);
                    SetWarningText(atomType, disabledDeps);
                }
            });

            row.Add(toggle);
            return row;
        }
    }
}
#endif
