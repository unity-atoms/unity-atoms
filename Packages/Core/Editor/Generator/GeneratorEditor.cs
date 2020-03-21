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
        /// <summary>
        /// Create the editor window.
        /// </summary>
        [MenuItem("Tools/Unity Atoms/Generator")]
        static void Init()
        {
            var window = GetWindow<GeneratorEditor>(false, "Unity Atoms - Generator");
            window.position = new Rect(Screen.width / 2, Screen.height / 2, 440, 540);
            window.Show();
        }

        private string _valueType = "";
        private bool _isValueTypeEquatable = true;
        private string _valueTypeNamespace = "";
        private string _subUnityAtomsNamespace = "";

        private List<AtomType> _atomTypesToGenerate = new List<AtomType>(AtomTypes.ALL_ATOM_TYPES);

        private Dictionary<AtomType, VisualElement> _typeVEDict = new Dictionary<AtomType, VisualElement>();
        private VisualElement _typesToGenerateInfoRow;

        /// <summary>
        /// Add provided `AtomType` to the list of Atom types to be generated.
        /// </summary>
        /// <param name="atomType">The `AtomType` to be added.</param>
        private void AddAtomTypeToGenerate(AtomType atomType)
        {
            _atomTypesToGenerate.Add(atomType);

            foreach (KeyValuePair<AtomType, List<AtomType>> entry in AtomTypes.DEPENDENCY_GRAPH)
            {
                if (!_typeVEDict.ContainsKey(entry.Key)) continue;

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

            foreach (KeyValuePair<AtomType, List<AtomType>> entry in AtomTypes.DEPENDENCY_GRAPH)
            {
                if (!_typeVEDict.ContainsKey(entry.Key)) continue;

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
        /// <param name="disabledDeps">List of disabled deps.</param>
        private void SetWarningText(AtomType atomType, List<AtomType> disabledDeps = null)
        {
            if (disabledDeps != null && disabledDeps.Count > 0)
            {
                string warningText = $"{String.Join(", ", disabledDeps.Select((a) => a.Name))} depend(s) on {atomType.Name}.";
                _typesToGenerateInfoRow.Query<Label>().First().text = warningText;
            }
            else
            {
                _typesToGenerateInfoRow.Query<Label>().First().text = "";
            }
        }

        private static string _baseWritePath = Runtime.IsUnityAtomsRepo
            ? "../Packages/BaseAtoms" : "Assets/Atoms";

        /// <summary>
        /// Called when editor is enabled.
        /// </summary>
        private void OnEnable()
        {
            var _atomTypesToGenerate = new List<AtomType>(AtomTypes.ALL_ATOM_TYPES);
#if UNITY_2019_1_OR_NEWER
            var root = this.rootVisualElement;
#elif UNITY_2018_4_OR_NEWER
            var root = this.GetRootVisualContainer();
#endif
            var pathRow = new VisualElement() { style = { flexDirection = FlexDirection.Row } };
            pathRow.Add(new Label() { text = "Relative Write Path", style = { width = 180, marginRight = 8 } });
            var textfield = new TextField() { value = _baseWritePath, style = { flexGrow = 1 } };
            textfield.RegisterCallback<ChangeEvent<string>>(evt => _baseWritePath = evt.newValue);
            pathRow.Add(textfield);
            root.Add(pathRow);

            var typeNameRow = new VisualElement() { style = { flexDirection = FlexDirection.Row } };
            typeNameRow.Add(new Label() { text = "Type Name", style = { width = 180, marginRight = 8 } });
            textfield = new TextField() { value = _valueType, style = { flexGrow = 1 } };
            textfield.RegisterCallback<ChangeEvent<string>>(evt => _valueType = evt.newValue);
            typeNameRow.Add(textfield);
            root.Add(typeNameRow);

            var equatableRow = new VisualElement() { style = { flexDirection = FlexDirection.Row } };
            equatableRow.Add(new Label() { text = "Is Type Equatable?", style = { width = 180, marginRight = 8 } });
            var equatableToggle = new Toggle() { value = _isValueTypeEquatable, style = { flexGrow = 1 } };
            equatableToggle.RegisterCallback<ChangeEvent<bool>>(evt => _isValueTypeEquatable = evt.newValue);
            equatableRow.Add(equatableToggle);
            root.Add(equatableRow);

            var typeNamespaceRow = new VisualElement() { style = { flexDirection = FlexDirection.Row } };
            typeNamespaceRow.Add(new Label() { text = "Type Namespace", style = { width = 180, marginRight = 8 } });
            textfield = new TextField() { value = _valueTypeNamespace, style = { flexGrow = 1 } };
            textfield.RegisterCallback<ChangeEvent<string>>(evt => _valueTypeNamespace = evt.newValue);
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

            foreach (var atomType in AtomTypes.ALL_ATOM_TYPES)
            {
                _typeVEDict.Add(atomType, CreateAtomTypeToGenerateToggleRow(atomType));
                root.Add(_typeVEDict[atomType]);
            }

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

            var button2 = new Button(() =>
            {
                var templates = Generator.GetTemplatePaths();
                var templateConditions = Generator.CreateTemplateConditions(_isValueTypeEquatable, _valueTypeNamespace, _subUnityAtomsNamespace);
                var templateVariables = Generator.CreateTemplateVariablesMap(_valueType, _valueTypeNamespace, _subUnityAtomsNamespace);
                var capitalizedValueType = _valueType.Capitalize();

                _atomTypesToGenerate.ForEach((atomType) =>
                {
                    templateVariables["VALUE_TYPE_NAME"] = atomType.IsValuePair ? $"{capitalizedValueType}Pair" : capitalizedValueType;
                    var valueType = atomType.IsValuePair ? $"{capitalizedValueType}Pair" : _valueType;
                    templateVariables["VALUE_TYPE"] = valueType;
                    Generator.Generate(new AtomReceipe(atomType, valueType), _baseWritePath, templates, templateConditions, templateVariables);
                });

                AssetDatabase.Refresh();
            })
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
            row.Add(new Label() { text = atomType.DisplayName, style = { width = 220, marginRight = 8 } });
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
