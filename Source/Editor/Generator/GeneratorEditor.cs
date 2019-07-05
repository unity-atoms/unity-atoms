#if UNITY_2019_1_OR_NEWER
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
            window.position = new Rect(Screen.width / 2, Screen.height / 2, 300, 100);
            window.Show();
        }

        private string _type = "";
        private bool _isEquatable = true;

        private static string _writePath = System.Environment.CurrentDirectory.Contains("unity-atoms/UnityAtomsTestsAndExamples")
            ? "../Source/" : "Assets/Atoms/";

        private void OnEnable()
        {
            generator = generator == null ? new Generator() : generator;

            var root = this.rootVisualElement;
            var inlineVE = new VisualElement() { style = { flexDirection = FlexDirection.Row } };
            inlineVE.Add(new Label() { text = "Relative Write Path", style = { width = 100 } });
            var textfield = new TextField() { value = _writePath, style = { flexGrow = 1 } };
            textfield.RegisterCallback<ChangeEvent<string>>(evt => _writePath = evt.newValue);
            inlineVE.Add(textfield);
            root.Add(inlineVE);

            inlineVE = new VisualElement() { style = { flexDirection = FlexDirection.Row } };
            inlineVE.Add(new Label() { text = "Type Name", style = { width = 100 } });
            textfield = new TextField() { value = _type, style = { flexGrow = 1 } };
            textfield.RegisterCallback<ChangeEvent<string>>(evt => _type = evt.newValue);
            inlineVE.Add(textfield);
            root.Add(inlineVE);

            inlineVE = new VisualElement() { style = { flexDirection = FlexDirection.Row } };
            inlineVE.Add(new Label() { text = "Is Type Equatable?", style = { width = 100 } });
            var toggle = new Toggle() { value = _isEquatable, style = { flexGrow = 1 } };
            toggle.RegisterCallback<ChangeEvent<bool>>(evt => _isEquatable = evt.newValue);
            inlineVE.Add(toggle);
            root.Add(inlineVE);


            inlineVE = new VisualElement()
            {
                style = { flexDirection = FlexDirection.Row }
            };

            var button1 = new Button(Close)
            {
                text = "Close",
                style = { flexGrow = 1 }
            };
            inlineVE.Add(button1);

            var button2 = new Button(() => generator.Generate(type: _type, baseWritePath: _writePath, isEquatable: _isEquatable))
            {
                text = "Generate",
                style = { flexGrow = 1 }
            };
            inlineVE.Add(button2);

            root.Add(inlineVE);
        }
    }
}
#endif
