using System.IO;
using System.Reflection;
using UnityEditor;
using UnityEditor.Experimental.UIElements;
using UnityEngine;
using UnityEngine.Experimental.UIElements;
using UnityEngine.Experimental.UIElements.StyleEnums;

namespace UnityAtoms {
    public class CodeGenerator : EditorWindow{

        [MenuItem("Tools/UnityAtoms/Code Gen Utility")]
        static void Init() {
            var window = GetWindow<CodeGenerator>();
            window.position = new Rect(Screen.width / 2, Screen.height / 2, 300, 100);
            // window.titleContent = new GUIContent("Code Generator");
            window.Show();
        }

        private string typeName = "";
        private static string writePath = "Assets/Source/Types/";

        private void OnEnable() {
            var root = this.GetRootVisualContainer();

            var inlineVE = new VisualElement() {    style = { flexDirection = FlexDirection.Row }    };
            inlineVE.Add(new Label() {text = "Write Path", style = {width = 100}});
            var textfield = new TextField() {value = writePath, style = {flexGrow = 1}};
            textfield.RegisterCallback<ChangeEvent<string>>(evt => writePath = evt.newValue);
            inlineVE.Add(textfield);
            root.Add(inlineVE);

            inlineVE = new VisualElement() {    style = { flexDirection = FlexDirection.Row }    };
            inlineVE.Add(new Label() {text = "Type Name", style = {width = 100}});
            textfield = new TextField() {value = typeName, style = {flexGrow = 1}};
            textfield.RegisterCallback<ChangeEvent<string>>(evt => typeName = evt.newValue);
            inlineVE.Add(textfield);
            root.Add(inlineVE);


            inlineVE = new VisualElement() {
                style = { flexDirection = FlexDirection.Row }
            };

            var button1 = new Button(Close) { text = "Close" , style = {flexGrow = 1} };
            inlineVE.Add(button1);

            var button2 = new Button(Generate) { text = "Generate" , style = {flexGrow = 1}};
            inlineVE.Add(button2);

            root.Add(inlineVE);
        }

        private void Generate() {
            if( string.IsNullOrEmpty(typeName) ) return;
            Debug.Log("Generating! " + typeName);

            Directory.CreateDirectory(writePath + $"{Capitalize(typeName)}");

            GenerateAction(typeName);
            GenerateConstant(typeName);
            GenerateEvent(typeName);
            GenerateEvent2(typeName);
            GenerateUnityEvent(typeName);
            GenerateList(typeName);
            GenerateListener(typeName);
            GenerateReference(typeName);
            GenerateVariable(typeName);

            AssetDatabase.Refresh();
        }

        #region Util_Functions

        private static string Capitalize(string s) {
            if (string.IsNullOrEmpty(s))
                return string.Empty;

            char[] a = s.ToCharArray();
            a[0] = char.ToUpper(a[0]);
            return new string(a);
        }

        private static void CreateFile(string typeName, string TEMPLATE, string name, string filename) {
            var content = TEMPLATE.Replace("{TYPENAME}", name).Replace("{TYPE}", typeName);
            var path = writePath + $"{name}/{filename}";
            File.WriteAllText(path, content);
            AssetDatabase.ImportAsset(path);
        }

        #endregion

        #region Code_Files



        private void GenerateAction(string typeName) {
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

        private void GenerateConstant(string typeName) {
            const string TEMPLATE =
@"using UnityEngine;

namespace UnityAtoms {
[CreateAssetMenu(menuName = ""Unity Atoms/{TYPENAME}/Constant"", fileName = ""{TYPENAME}Constant"", order = CreateAssetMenuUtils.Order.CONSTANT)]
    public class {TYPENAME}Constant : ScriptableObjectVariableBase<{TYPE}> {
    }
}";
            var name = Capitalize(typeName);
            var filename = Capitalize(MethodBase.GetCurrentMethod().Name.Remove(0, "Generate".Length));
            filename = $"{name}{filename}.cs";
            CreateFile(typeName, TEMPLATE, name, filename);
        }

        private void GenerateEvent(string typeName) {
            const string TEMPLATE =
@"using UnityEngine;

namespace UnityAtoms {
[CreateAssetMenu(menuName = ""Unity Atoms/{TYPENAME}/Event"", fileName = ""{TYPENAME}Event"", order = CreateAssetMenuUtils.Order.EVENT)]
    public class {TYPENAME}Event : GameEvent<{TYPE}> {
    }
}";
            var name = Capitalize(typeName);
            var filename = Capitalize(MethodBase.GetCurrentMethod().Name.Remove(0, "Generate".Length));
            filename = $"{name}{filename}.cs";
            CreateFile(typeName, TEMPLATE, name, filename);
        }

        private void GenerateEvent2(string typeName) {
            const string TEMPLATE =
@"using UnityEngine;

namespace UnityAtoms {
    [CreateAssetMenu(menuName = ""Unity Atoms/{TYPENAME}/Event x 2"", fileName = ""{TYPENAME}{TYPENAME}Event"", order = CreateAssetMenuUtils.Order.EVENTx2)]
    public class {TYPENAME}{TYPENAME}Event : GameEvent<{TYPE}, {TYPE}> {
    }
}";
            var name = Capitalize(typeName);
            var filename = $"{name}{name}Event.cs";
            CreateFile(typeName, TEMPLATE, name, filename);
        }

        private void GenerateUnityEvent(string typeName) {
            const string TEMPLATE =
@"using System;
using UnityEngine;
using UnityEngine.Events;

namespace UnityAtoms {
    [Serializable]
    public class Unity{TYPENAME}Event : UnityEvent<{TYPE}> {
    }
}";
            var name = Capitalize(typeName);
            var filename = $"Unity{name}Event.cs";
            CreateFile(typeName, TEMPLATE, name, filename);
        }

        private void GenerateList(string typeName) {
            const string TEMPLATE =
@"using UnityEngine;

namespace UnityAtoms {
[CreateAssetMenu(menuName = ""Unity Atoms/{TYPENAME}/List"", fileName = ""{TYPENAME}List"", order = CreateAssetMenuUtils.Order.LIST)]
    public class {TYPENAME}List : ScriptableObjectList<{TYPE}, {TYPENAME}Event> {
    }
}";
            var name = Capitalize(typeName);
            var filename = Capitalize(MethodBase.GetCurrentMethod().Name.Remove(0, "Generate".Length));
            filename = $"{name}{filename}.cs";
            CreateFile(typeName, TEMPLATE, name, filename);
        }

        private void GenerateListener(string typeName) {
            const string TEMPLATE =
@"using UnityEngine;

namespace UnityAtoms {
    public class {TYPENAME}Listener : GameEventListener<{TYPE}, {TYPENAME}Action, {TYPENAME}Event, Unity{TYPENAME}Event> {
    }
}";
            var name = Capitalize(typeName);
            var filename = Capitalize(MethodBase.GetCurrentMethod().Name.Remove(0, "Generate".Length));
            filename = $"{name}{filename}.cs";
            CreateFile(typeName, TEMPLATE, name, filename);
        }

        private void GenerateReference(string typeName) {
            const string TEMPLATE =
@"using UnityEngine;
using System;

namespace UnityAtoms {
    [Serializable]
    public class {TYPENAME}Reference : ScriptableObjectReference<{TYPE}, {TYPENAME}Variable, {TYPENAME}Event, {TYPENAME}{TYPENAME}Event> {
    }
}";
            var name = Capitalize(typeName);
            var filename = Capitalize(MethodBase.GetCurrentMethod().Name.Remove(0, "Generate".Length));
            filename = $"{name}{filename}.cs";
            CreateFile(typeName, TEMPLATE, name, filename);
        }

        private void GenerateVariable(string typeName) {
            const string TEMPLATE =
@"using UnityEngine;

namespace UnityAtoms {
[CreateAssetMenu(menuName = ""Unity Atoms/{TYPENAME}/Variable"", fileName = ""{TYPENAME}Variable"", order = CreateAssetMenuUtils.Order.VARIABLE)]
    public class {TYPENAME}Variable : EquatableScriptableObjectVariable<{TYPE}, {TYPENAME}Event, {TYPENAME}{TYPENAME}Event> {
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
