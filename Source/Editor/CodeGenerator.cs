#if UNITY_2019_1_OR_NEWER
using System.IO;
using System.Reflection;
using UnityEditor;
using UnityEngine;
using UnityAtoms.Logger;
using UnityEngine.UIElements;

namespace UnityAtoms
{
    public class CodeGenerator : EditorWindow
    {

        [MenuItem("Tools/Unity Atoms/Code Gen Utility")]
        static void Init()
        {
            var window = GetWindow<CodeGenerator>();
            window.position = new Rect(Screen.width / 2, Screen.height / 2, 300, 100);
            window.Show();
        }

        private string _typeName = "";

        private static string _writePath = System.Environment.CurrentDirectory.Contains("unity-atoms/UnityAtomsTestsAndExamples")
            ? "../Source/Types/" : "Assets/Source/Types/";

        private void OnEnable()
        {

            var root = this.rootVisualElement;
            var root = this.GetRootVisualContainer();
            var inlineVE = new VisualElement() { style = { flexDirection = FlexDirection.Row } };
            inlineVE.Add(new Label() { text = "Write Path", style = { width = 100 } });
            var textfield = new TextField() { value = _writePath, style = { flexGrow = 1 } };
            textfield.RegisterCallback<ChangeEvent<string>>(evt => _writePath = evt.newValue);
            inlineVE.Add(textfield);
            root.Add(inlineVE);

            inlineVE = new VisualElement() { style = { flexDirection = FlexDirection.Row } };
            inlineVE.Add(new Label() { text = "Type Name", style = { width = 100 } });
            textfield = new TextField() { value = _typeName, style = { flexGrow = 1 } };
            textfield.RegisterCallback<ChangeEvent<string>>(evt => _typeName = evt.newValue);
            inlineVE.Add(textfield);
            root.Add(inlineVE);


            inlineVE = new VisualElement()
            {
                style = { flexDirection = FlexDirection.Row }
            };

            var button1 = new Button(Close) { text = "Close", style = { flexGrow = 1 } };
            inlineVE.Add(button1);

            var button2 = new Button(Generate) { text = "Generate", style = { flexGrow = 1 } };
            inlineVE.Add(button2);

            root.Add(inlineVE);
        }

        private void Generate()
        {
            if (string.IsNullOrEmpty(_typeName))
            {
                AtomsLogger.Warning("You need to specify a type name. Aborting!");
                return;
            }
            AtomsLogger.Log("Generating " + _typeName);

            GenerateAction(_typeName);
            GenerateConstant(_typeName);
            GenerateEvent(_typeName);
            GenerateEvent2(_typeName);
            GenerateUnityEvent(_typeName);
            GenerateList(_typeName);
            GenerateListener(_typeName);
            GenerateReference(_typeName);
            GenerateVariable(_typeName);

            AssetDatabase.Refresh();
        }

#region Util_Functions

        private static string Capitalize(string s)
        {
            if (string.IsNullOrEmpty(s))
                return string.Empty;

            char[] a = s.ToCharArray();
            a[0] = char.ToUpper(a[0]);
            return new string(a);
        }

        private static void CreateFile(string typeName, string TEMPLATE, string name, string filename)
        {
            var content = TEMPLATE.Replace("{TYPENAME}", name).Replace("{TYPE}", typeName);
            var path = _writePath + $"{name}/{filename}";
            File.WriteAllText(path, content);
            AssetDatabase.ImportAsset(path);
        }

#endregion

#region Code_Files

        private void GenerateAction(string typeName)
        {
            const string TEMPLATE =
@"using UnityEngine;

namespace UnityAtoms {
    public abstract class {TYPENAME}Action : GameAction<{TYPE}> {
    }
}";
            var name = Capitalize(typeName);
            var filename = Capitalize(MethodBase.GetCurrentMethod().Name.Remove(0, "Generate".Length));
            filename = $"{name}{filename}.cs";
            CreateFile(typeName, TEMPLATE, name, filename);
        }

        private void GenerateConstant(string typeName)
        {
            const string TEMPLATE =
@"using UnityEngine;

namespace UnityAtoms {
[CreateAssetMenu(menuName = ""Unity Atoms/{TYPENAME}/Constant"", fileName = ""{TYPENAME}Constant"", order = CreateAssetMenuUtils.Order.CONSTANT)]
    public sealed class {TYPENAME}Constant : ScriptableObjectVariableBase<{TYPE}> {
    }
}";
            var name = Capitalize(typeName);
            var filename = Capitalize(MethodBase.GetCurrentMethod().Name.Remove(0, "Generate".Length));
            filename = $"{name}{filename}.cs";
            CreateFile(typeName, TEMPLATE, name, filename);
        }

        private void GenerateEvent(string typeName)
        {
            const string TEMPLATE =
@"using UnityEngine;

namespace UnityAtoms {
[CreateAssetMenu(menuName = ""Unity Atoms/{TYPENAME}/Event"", fileName = ""{TYPENAME}Event"", order = CreateAssetMenuUtils.Order.EVENT)]
    public sealed class {TYPENAME}Event : GameEvent<{TYPE}> {
    }
}";
            var name = Capitalize(typeName);
            var filename = Capitalize(MethodBase.GetCurrentMethod().Name.Remove(0, "Generate".Length));
            filename = $"{name}{filename}.cs";
            CreateFile(typeName, TEMPLATE, name, filename);
        }

        private void GenerateEvent2(string typeName)
        {
            const string TEMPLATE =
@"using UnityEngine;

namespace UnityAtoms {
    [CreateAssetMenu(menuName = ""Unity Atoms/{TYPENAME}/Event x 2"", fileName = ""{TYPENAME}{TYPENAME}Event"", order = CreateAssetMenuUtils.Order.EVENTx2)]
    public sealed class {TYPENAME}{TYPENAME}Event : GameEvent<{TYPE}, {TYPE}> {
    }
}";
            var name = Capitalize(typeName);
            var filename = $"{name}{name}Event.cs";
            CreateFile(typeName, TEMPLATE, name, filename);
        }

        private void GenerateUnityEvent(string typeName)
        {
            const string TEMPLATE =
@"using System;
using UnityEngine;
using UnityEngine.Events;

namespace UnityAtoms {
    [Serializable]
    public sealed class Unity{TYPENAME}Event : UnityEvent<{TYPE}> {
    }
}";
            var name = Capitalize(typeName);
            var filename = $"Unity{name}Event.cs";
            CreateFile(typeName, TEMPLATE, name, filename);
        }

        private void GenerateList(string typeName)
        {
            const string TEMPLATE =
@"using UnityEngine;

namespace UnityAtoms {
[CreateAssetMenu(menuName = ""Unity Atoms/{TYPENAME}/List"", fileName = ""{TYPENAME}List"", order = CreateAssetMenuUtils.Order.LIST)]
    public sealed class {TYPENAME}List : ScriptableObjectList<{TYPE}, {TYPENAME}Event> {
    }
}";
            var name = Capitalize(typeName);
            var filename = Capitalize(MethodBase.GetCurrentMethod().Name.Remove(0, "Generate".Length));
            filename = $"{name}{filename}.cs";
            CreateFile(typeName, TEMPLATE, name, filename);
        }

        private void GenerateListener(string typeName)
        {
            const string TEMPLATE =
@"using UnityEngine;

namespace UnityAtoms {
    public sealed class {TYPENAME}Listener : GameEventListener<{TYPE}, {TYPENAME}Action, {TYPENAME}Event, Unity{TYPENAME}Event> {
    }
}";
            var name = Capitalize(typeName);
            var filename = Capitalize(MethodBase.GetCurrentMethod().Name.Remove(0, "Generate".Length));
            filename = $"{name}{filename}.cs";
            CreateFile(typeName, TEMPLATE, name, filename);
        }

        private void GenerateReference(string typeName)
        {
            const string TEMPLATE =
@"using UnityEngine;
using System;

namespace UnityAtoms {
    [Serializable]
    public sealed class {TYPENAME}Reference : ScriptableObjectReference<{TYPE}, {TYPENAME}Variable> {
    }
}";
            var name = Capitalize(typeName);
            var filename = Capitalize(MethodBase.GetCurrentMethod().Name.Remove(0, "Generate".Length));
            filename = $"{name}{filename}.cs";
            CreateFile(typeName, TEMPLATE, name, filename);
        }

        private void GenerateVariable(string typeName)
        {
            const string TEMPLATE =
@"using UnityEngine;

namespace UnityAtoms {
[CreateAssetMenu(menuName = ""Unity Atoms/{TYPENAME}/Variable"", fileName = ""{TYPENAME}Variable"", order = CreateAssetMenuUtils.Order.VARIABLE)]
    public sealed class {TYPENAME}Variable : ScriptableObjectVariable<{TYPE}, {TYPENAME}Event, {TYPENAME}{TYPENAME}Event> {
    }
}";
            var name = Capitalize(typeName);
            var filename = Capitalize(MethodBase.GetCurrentMethod().Name.Remove(0, "Generate".Length));
            filename = $"{name}{filename}.cs";
            CreateFile(typeName, TEMPLATE, name, filename);
        }

#endregion
    }
}
#endif
