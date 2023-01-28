#if UNITY_2019_1_OR_NEWER && !UNITY_ATOMS_GENERATE_DOCS
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms;

namespace UnityAtoms.Editor
{
    public static class StackTraceEditor
    {
        public static VisualElement RenderStackTrace(VisualElement parent, int instanceId)
        {
            if (!AtomPreferences.IsDebugModeEnabled) return null;
            var stackTraces = StackTraces.GetStackTraces(instanceId);

            var foldout = GetOrCreate<Foldout>(parent, "STACK_TRACES_FOLDOUT", (element) =>
            {
                element.style.marginTop = 4;
                element.style.marginBottom = 4;
                element.text = "Stack traces";
            });

            var wrapper = GetOrCreate<VisualElement>(foldout, "STACK_TRACES_ROOT", (element) =>
            {
                element.style.flexDirection = FlexDirection.Column;
            });

            var header = GetOrCreate<VisualElement>(wrapper, "HEADER", (element) =>
            {
                element.style.flexDirection = FlexDirection.Row;
                element.style.justifyContent = Justify.SpaceBetween;
                element.style.alignItems = Align.Center;
                element.style.backgroundColor = GetHeaderColor();
                element.style.paddingLeft = 4;
                element.style.paddingRight = 4;
                element.style.paddingTop = 2;
                element.style.paddingBottom = 2;
            });

            var title = GetOrCreate<Label>(header, "TITLE", (label) =>
            {
                label.text = "Overview";
                label.style.unityFontStyleAndWeight = FontStyle.Bold;
            });

            var clearButton = GetOrCreate<Button>(header, "CLEAR_BUTTON", (button) =>
            {
                button.text = "Clear";
                button.clickable.clicked += () =>
                {
                    SetSelectedStackTraceId(instanceId, -1);
                    StackTraces.ClearStackTraces(instanceId);
                };
            });

            // All stack traces
            RenderStackTracesOverview(wrapper, stackTraces, instanceId);
            RenderStackTraceDetails(wrapper, stackTraces, instanceId);

            // Rerender on change
            stackTraces.CollectionChanged += (sender, e) =>
            {
                RenderStackTracesOverview(wrapper, stackTraces, instanceId);
                RenderStackTraceDetails(wrapper, stackTraces, instanceId);
            };

            return wrapper;
        }

        private static void RenderStackTraceDetails(VisualElement parent, ObservableCollection<StackTraceEntry> stackTraces, int instanceId)
        {
            var selectedStackTraceId = GetSelectedStackTraceId(instanceId);

            var wrapper = GetOrCreate<VisualElement>(parent, "STACK_TRACES_DETAILS_WRAPPER");

            var header = GetOrCreate<VisualElement>(wrapper, "HEADER", (element) =>
            {
                element.style.flexDirection = FlexDirection.Row;
                element.style.justifyContent = Justify.FlexStart;
                element.style.alignItems = Align.Center;
                element.style.backgroundColor = GetHeaderColor();
                element.style.paddingLeft = 4;
                element.style.paddingRight = 4;
                element.style.paddingTop = 6;
                element.style.paddingBottom = 6;
                element.style.display = selectedStackTraceId != -1 ? DisplayStyle.Flex : DisplayStyle.None;
            });

            var title = GetOrCreate<Label>(header, "TITLE", (label) =>
            {
                label.text = "Details";
                label.style.unityFontStyleAndWeight = FontStyle.Bold;
            });

            var stackTracesDetails = GetOrCreate<ScrollView>(wrapper, "SCROLL_VIEW", (scrollView) =>
            {
                scrollView.style.maxHeight = 100;
                scrollView.style.height = 100;
                scrollView.style.backgroundColor = GetBodyColor();
                scrollView.showVertical = true;
                scrollView.style.display = selectedStackTraceId != -1 ? DisplayStyle.Flex : DisplayStyle.None;
            });

            var details = GetOrCreate<TextField>(stackTracesDetails, "DETAILS", (field) =>
            {
                field.isReadOnly = true;
                field.multiline = true;
                field.value = selectedStackTraceId != -1 ? stackTraces[selectedStackTraceId].ToString() : "";
                field.style.borderLeftWidth = 0;
                field.style.borderRightWidth = 0;
                field.style.borderTopWidth = 0;
                field.style.borderBottomWidth = 0;
                field.style.marginLeft = 1;
                field.style.marginRight = 1;
                field.style.marginTop = 1;
                field.style.marginBottom = 1;
            });
        }

        private static void RenderStackTracesOverview(VisualElement parent, ObservableCollection<StackTraceEntry> stackTraces, int instanceId)
        {
            var selectedStackTraceId = GetSelectedStackTraceId(instanceId);

            var stackTracesOverview = GetOrCreate<ScrollView>(parent, "STACK_TRACES_OVERVIEW_SCROLL_VIEW", (scrollView) =>
            {
                scrollView.style.maxHeight = 100;
                scrollView.style.height = 100;
                scrollView.style.backgroundColor = GetBodyColor();
                scrollView.showVertical = true;
            });
            var stackTracesOverviewRowContainer = GetOrCreate<VisualElement>(stackTracesOverview, "STACK_TRACES_OVERVIEW_ROW_CONTAINER");
            stackTracesOverviewRowContainer.style.flexDirection = FlexDirection.Column;

            stackTracesOverviewRowContainer.Clear();
            for (var i = 0; i < stackTraces.Count; ++i)
            {
                var index = i;
                var stackTrace = stackTraces[index];
                var row = new Label()
                {
                    text = stackTrace.ToString().GetFirstLine(),
                    style =
                    {
                        paddingTop = 4,
                        paddingBottom = 4,
                        paddingLeft = 4,
                        paddingRight = 4,
                    }
                };

                if (selectedStackTraceId == index)
                {
                    row.style.color = Color.yellow;
                }

                row.RegisterCallback<MouseDownEvent>((e) =>
                {
                    SetSelectedStackTraceId(instanceId, index);
                    RenderStackTracesOverview(parent, stackTraces, instanceId);
                    RenderStackTraceDetails(parent, stackTraces, instanceId);
                });

                stackTracesOverviewRowContainer.Add(row);
            }
        }

        private static T GetOrCreate<T>(VisualElement parent, string name, Action<T> initializer = null) where T : VisualElement, new()
        {
            var element = (T)parent.Query<VisualElement>(name: name).First() ?? new T() { name = name };
            if (initializer != null)
            {
                initializer(element);
            }
            if (!parent.Contains(element))
                parent.Add(element);
            return element;
        }

        private static Color GetHeaderColor()
        {
            var proColor = new Color(44f / 255f, 44f / 255f, 44f / 255f);
            var basicColor = new Color(154f / 255f, 154f / 255f, 154f / 255f);
            return EditorGUIUtility.isProSkin ? proColor : basicColor;
        }

        private static Color GetBodyColor()
        {
            var proColor = new Color(83f / 255f, 83f / 255f, 83f / 255f);
            var basicColor = new Color(174f / 255f, 174f / 255f, 174f / 255f);
            return EditorGUIUtility.isProSkin ? proColor : basicColor;
        }

        private static Dictionary<int, int> _stackTraceIdSelectedPerInstanceId = new Dictionary<int, int>();
        private static int GetSelectedStackTraceId(int instanceId)
        {
            if (!_stackTraceIdSelectedPerInstanceId.ContainsKey(instanceId)) _stackTraceIdSelectedPerInstanceId.Add(instanceId, -1);

            return _stackTraceIdSelectedPerInstanceId[instanceId];
        }

        private static void SetSelectedStackTraceId(int instanceId, int selectedIndex)
        {
            if (!_stackTraceIdSelectedPerInstanceId.ContainsKey(instanceId)) _stackTraceIdSelectedPerInstanceId.Add(instanceId, -1);

            _stackTraceIdSelectedPerInstanceId[instanceId] = selectedIndex;
        }
    }
}
#endif