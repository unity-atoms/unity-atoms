#if UNITY_2019_1_OR_NEWER
using System;
using System.Linq;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

namespace UnityAtoms.Editor
{
    public class GeneratorEditor : EditorWindow
    {
        private Generator generator;

        [MenuItem("Tools/Unity Atoms/Generator")]
        static void Init()
        {
            var window = GetWindow<GeneratorEditor>(false, "Generator");
            window.position = new Rect(Screen.width / 2, Screen.height / 2, 400, 280);
            window.Show();
        }

        public static readonly string ACTION = "Action";
        public static readonly string CONSTANT = "Constant";
        public static readonly string EVENT = "Event";
        public static readonly string EVENT_X2 = "Event x 2";
        public static readonly string LIST = "List";
        public static readonly string LISTENER = "Listener";
        public static readonly string REFERENCE = "Reference";
        public static readonly string SET_VARIABLE_VALUE = "Set Variable Value (Action)";
        public static readonly string UNITY_EVENT = "Unity Event";
        public static readonly string VARIABLE = "Variable";

        private string _type = "";
        private bool _isEquatable = true;

        private List<AtomType> _atomTypesToGenerate = new List<AtomType>()
        {
            AtomTypes.ACTION,
            AtomTypes.CONSTANT,
            AtomTypes.EVENT,
            AtomTypes.EVENT_X2,
            AtomTypes.LIST,
            AtomTypes.LISTENER,
            AtomTypes.REFERENCE,
            AtomTypes.SET_VARIABLE_VALUE,
            AtomTypes.UNITY_EVENT,
            AtomTypes.VARIABLE
        };
        private Dictionary<AtomType, VisualElement> _typeVEDict = new Dictionary<AtomType, VisualElement>();
        private VisualElement _typesToGenerateInfoRow;

        private Dictionary<AtomType, List<AtomType>> _dependencies = new Dictionary<AtomType, List<AtomType>>() {
            { AtomTypes.LIST, new List<AtomType>() { AtomTypes.EVENT } },
            { AtomTypes.LISTENER, new List<AtomType>() { AtomTypes.ACTION, AtomTypes.EVENT, AtomTypes.UNITY_EVENT } },
            { AtomTypes.REFERENCE, new List<AtomType>() { AtomTypes.VARIABLE } },
            { AtomTypes.SET_VARIABLE_VALUE, new List<AtomType>() { AtomTypes.VARIABLE, AtomTypes.REFERENCE, AtomTypes.EVENT, AtomTypes.EVENT_X2 } },
            { AtomTypes.VARIABLE, new List<AtomType>() { AtomTypes.EVENT, AtomTypes.EVENT_X2 } }
        };




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

        private static string _writePath = System.Environment.CurrentDirectory.Contains("unity-atoms/UnityAtomsTestsAndExamples")
            ? "../Source/" : "Assets/Atoms/";

        private void OnEnable()
        {
            _atomTypesToGenerate = new List<AtomType>() { AtomTypes.ACTION, AtomTypes.CONSTANT, AtomTypes.EVENT, AtomTypes.EVENT_X2, AtomTypes.LIST, AtomTypes.LISTENER, AtomTypes.REFERENCE, AtomTypes.SET_VARIABLE_VALUE, AtomTypes.UNITY_EVENT, AtomTypes.VARIABLE };
            generator = generator == null ? new Generator() : generator;

            var root = this.rootVisualElement;
            var pathRow = new VisualElement() { style = { flexDirection = FlexDirection.Row } };
            pathRow.Add(new Label() { text = "Relative Write Path", style = { width = 100, marginRight = 8 } });
            var textfield = new TextField() { value = _writePath, style = { flexGrow = 1 } };
            textfield.RegisterCallback<ChangeEvent<string>>(evt => _writePath = evt.newValue);
            pathRow.Add(textfield);
            root.Add(pathRow);

            var typeNameRow = new VisualElement() { style = { flexDirection = FlexDirection.Row } };
            typeNameRow.Add(new Label() { text = "Type Name", style = { width = 100, marginRight = 8 } });
            textfield = new TextField() { value = _type, style = { flexGrow = 1 } };
            textfield.RegisterCallback<ChangeEvent<string>>(evt => _type = evt.newValue);
            typeNameRow.Add(textfield);
            root.Add(typeNameRow);

            var equatableRow = new VisualElement() { style = { flexDirection = FlexDirection.Row } };
            equatableRow.Add(new Label() { text = "Is Type Equatable?", style = { width = 100, marginRight = 8 } });
            var equatableToggle = new Toggle() { value = _isEquatable, style = { flexGrow = 1 } };
            equatableToggle.RegisterCallback<ChangeEvent<bool>>(evt => _isEquatable = evt.newValue);
            equatableRow.Add(equatableToggle);
            root.Add(equatableRow);

            root.Add(CreateDivider());

            var typesToGenerateLabelRow = new VisualElement() { style = { flexDirection = FlexDirection.Row } };
            typesToGenerateLabelRow.Add(new Label() { text = "Type(s) to Generate" });
            root.Add(typesToGenerateLabelRow);

            _typeVEDict.Add(AtomTypes.ACTION, CreateAtomTypeToGenerateToggleRow(AtomTypes.ACTION));
            root.Add(_typeVEDict[AtomTypes.ACTION]);
            _typeVEDict.Add(AtomTypes.CONSTANT, CreateAtomTypeToGenerateToggleRow(AtomTypes.CONSTANT));
            root.Add(_typeVEDict[AtomTypes.CONSTANT]);
            _typeVEDict.Add(AtomTypes.EVENT, CreateAtomTypeToGenerateToggleRow(AtomTypes.EVENT));
            root.Add(_typeVEDict[AtomTypes.EVENT]);
            _typeVEDict.Add(AtomTypes.EVENT_X2, CreateAtomTypeToGenerateToggleRow(AtomTypes.EVENT_X2));
            root.Add(_typeVEDict[AtomTypes.EVENT_X2]);
            _typeVEDict.Add(AtomTypes.LIST, CreateAtomTypeToGenerateToggleRow(AtomTypes.LIST));
            root.Add(_typeVEDict[AtomTypes.LIST]);
            _typeVEDict.Add(AtomTypes.LISTENER, CreateAtomTypeToGenerateToggleRow(AtomTypes.LISTENER));
            root.Add(_typeVEDict[AtomTypes.LISTENER]);
            _typeVEDict.Add(AtomTypes.REFERENCE, CreateAtomTypeToGenerateToggleRow(AtomTypes.REFERENCE));
            root.Add(_typeVEDict[AtomTypes.REFERENCE]);
            _typeVEDict.Add(AtomTypes.SET_VARIABLE_VALUE, CreateAtomTypeToGenerateToggleRow(AtomTypes.SET_VARIABLE_VALUE));
            root.Add(_typeVEDict[AtomTypes.SET_VARIABLE_VALUE]);
            _typeVEDict.Add(AtomTypes.UNITY_EVENT, CreateAtomTypeToGenerateToggleRow(AtomTypes.UNITY_EVENT));
            root.Add(_typeVEDict[AtomTypes.UNITY_EVENT]);
            _typeVEDict.Add(AtomTypes.VARIABLE, CreateAtomTypeToGenerateToggleRow(AtomTypes.VARIABLE));
            root.Add(_typeVEDict[AtomTypes.VARIABLE]);

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

            var button2 = new Button(() => generator.Generate(type: _type, baseWritePath: _writePath, isEquatable: _isEquatable, atomTypesToGenerate: _atomTypesToGenerate))
            {
                text = "Generate",
                style = { flexGrow = 1 }
            };
            buttonRow.Add(button2);
            root.Add(buttonRow);
        }

        private VisualElement CreateDivider()
        {
            return new VisualElement()
            {
                style = { flexDirection = FlexDirection.Row, marginBottom = 2, marginTop = 2, marginLeft = 2, marginRight = 2, height = 1 }
            };
        }

        private VisualElement CreateAtomTypeToGenerateToggleRow(AtomType atomType)
        {
            var row = new VisualElement() { style = { flexDirection = FlexDirection.Row } };
            row.Add(new Label() { text = atomType.DisplayName, style = { width = 150, marginRight = 8 } });
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
