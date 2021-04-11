#if UNITY_EDITOR
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
#if UNITY_2019_1_OR_NEWER
using UnityEngine.UIElements;
#endif

namespace UnityAtoms
{
    /// <summary>
    /// Class to set preferences for Unity Atoms.
    /// </summary>
    public static class AtomPreferences
    {
        public abstract class Preference<T>
        {
            public T DefaultValue { get; set; }
            public string Key { get; set; }

            public abstract T Get();
            public abstract void Set(T value);
        }

        public class BoolPreference : Preference<bool>
        {
            public override bool Get()
            {
                if (!EditorPrefs.HasKey(Key))
                {
                    EditorPrefs.SetBool(Key, DefaultValue);
                }

                return EditorPrefs.GetBool(Key);
            }

            public override void Set(bool value)
            {
                EditorPrefs.SetBool(Key, value);
            }
        }

        public static bool IsDebugModeEnabled { get => DEBUG_MODE_PREF.Get(); }

        private static BoolPreference DEBUG_MODE_PREF = new BoolPreference() { DefaultValue = false, Key = "UnityAtoms.DebugMode" };

#if UNITY_2019_1_OR_NEWER
        [SettingsProvider]
        public static SettingsProvider CreateMyCustomSettingsProvider()
        {
            // First parameter is the path in the Settings window.
            // Second parameter is the scope of this setting: it only appears in the Settings window for the User scope.
            return new SettingsProvider("Preferences/UnityAtoms", SettingsScope.User)
            {
                label = "Unity Atoms",
                // activateHandler is called when the user clicks on the Settings item in the Settings window.
                activateHandler = (searchContext, rootElement) =>
                {
                    var wrapper = new VisualElement()
                    {
                        style =
                        {
                        marginBottom = 2,
                        marginTop = 2,
                        marginLeft = 8,
                        marginRight = 8,
                        flexDirection = FlexDirection.Column,
                        }
                    };

                    var title = new Label()
                    {
                        text = "Unity Atoms",
                        style =
                        {
                        fontSize = 20,
                        marginBottom = 12,
                        unityFontStyleAndWeight = FontStyle.Bold,
                        },
                    };
                    wrapper.Add(title);

                    var enableDebug = new Toggle()
                    {
                        label = "Debug mode",
                        value = DEBUG_MODE_PREF.Get(),
                        tooltip = "Enables debug functionality in Unity Atoms, for example Stack Traces for Events. Performance will decrease using this option, but could be switched on for debugging purposes.",
                    };
                    enableDebug.RegisterValueChangedCallback((changeEvt) => DEBUG_MODE_PREF.Set(changeEvt.newValue));
                    wrapper.Add(enableDebug);

                    rootElement.Add(wrapper);
                },

                keywords = new HashSet<string>(new[] { "Atoms", "Unity Atoms" })
            };
        }
#endif
    }
}
#endif