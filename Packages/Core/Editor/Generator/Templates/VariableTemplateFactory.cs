using System;
using System.Collections.ObjectModel;
using UnityEditor;
using UnityEngine;

namespace UnityAtoms.Editor
{
    [InitializeOnLoad]
    public static class VariableTemplateFactory
    {
        public const string atomName = "Variable";

        static VariableTemplateFactory()
        {
            AtomGenerator.populators += AtomPopulator;
            AtomGenerator.evaluators += AtomEvaluator;
        }

        private static void AtomPopulator(Type generatedType, System.Collections.Generic.Dictionary<string, Template> templates)
        {
            var atomTemplate = GetTemplate(generatedType);
            templates.Add(atomName, atomTemplate);
        }

        private static void AtomEvaluator(Type generatedType, ReadOnlyDictionary<string, Generator.Solver> solvers)
        {
            var solver = solvers[atomName];

            if (generatedType.IsEquatable())
            {
                solver.template.baseClass = typeof(EquatableAtomVariable<>).MakeGenericType(generatedType);

                var body = string.Empty;

                if (generatedType.IsColor())
                {
                    body =
$@"
        /// <summary>
        /// Set Alpha of Color by value.
        /// </summary>
        /// <param name=""value"">New alpha value.</param>
        public void SetAlpha(float value) => Value = new Color(Value.r, Value.g, Value.b, value);

        /// <summary>
        /// Set Alpha of Color by Variable value.
        /// </summary>
        /// <param name=""variable"">New alpha Variable value.</param>
        public void SetAlpha(AtomBaseVariable<float> variable) => SetAlpha(variable.Value);
    ";
                }
                else if (generatedType.IsNumeric())
                {
                    body =
$@"
        /// <summary>
        /// Add value to Variable.
        /// </summary>
        /// <param name=""value"">Value to add.</param>
        public void Add({generatedType.CodeCompatibleFullName()} value) => Value += value;

        /// <summary>
        /// Add variable value to Variable.
        /// </summary>
        /// <param name=""variable"">Variable with value to add.</param>
        public void Add(AtomBaseVariable<{generatedType.CodeCompatibleFullName()}> variable) => Add(variable.Value);

        /// <summary>
        /// Subtract value from Variable.
        /// </summary>
        /// <param name=""value"">Value to subtract.</param>
        public void Subtract({generatedType.CodeCompatibleFullName()} value) => Value -= value;

        /// <summary>
        /// Subtract variable value from Variable.
        /// </summary>
        /// <param name=""variable"">Variable with value to subtract.</param>
        public void Subtract(AtomBaseVariable<{generatedType.CodeCompatibleFullName()}> variable) => Subtract(variable.Value);

        /// <summary>
        /// Multiply variable by value.
        /// </summary>
        /// <param name=""value"">Value to multiple by.</param>
        public void MultiplyBy({generatedType.CodeCompatibleFullName()} value) => Value *= value;

        /// <summary>
        /// Multiply variable by Variable value.
        /// </summary>
        /// <param name=""variable"">Variable with value to multiple by.</param>
        public void MultiplyBy(AtomBaseVariable<{generatedType.CodeCompatibleFullName()}> variable) => MultiplyBy(variable.Value);

        /// <summary>
        /// Divide Variable by value.
        /// </summary>
        /// <param name=""value"">Value to divide by.</param>
        public void DivideBy({generatedType.CodeCompatibleFullName()} value) => Value /= value;

        /// <summary>
        /// Divide Variable by Variable value.
        /// </summary>
        /// <param name=""variable"">Variable value to divide by.</param>
        public void DivideBy(AtomBaseVariable<{generatedType.CodeCompatibleFullName()}> variable) => DivideBy(variable.Value);
    ";
                }
                else if (generatedType.IsVector())
                {
                    body =
$@"
        /// <summary>
        /// Multiply variable by value.
        /// </summary>
        /// <param name=""value"">Value to multiple by.</param>
        public void MultiplyBy(float value) => Value *= value;

        /// <summary>
        /// Multiply variable by Variable value.
        /// </summary>
        /// <param name=""variable"">Variable with value to multiple by.</param>
        public void MultiplyBy(AtomBaseVariable<float> variable) => MultiplyBy(variable.Value);

        /// <summary>
        /// Divide Variable by value.
        /// </summary>
        /// <param name=""value"">Value to divide by.</param>
        public void DivideBy(float value) => Value /= value;

        /// <summary>
        /// Divide Variable by Variable value.
        /// </summary>
        /// <param name=""variable"">Variable value to divide by.</param>
        public void DivideBy(AtomBaseVariable<float> variable) => DivideBy(variable.Value);
    ";
                }

                solver.template.body += body;
            }
            else
            {
                solver.template.baseClass = typeof(AtomVariable<>).MakeGenericType(generatedType);

                string valueEqualsMethodContent = "throw new System.NotImplementedException();";

                if (generatedType == typeof(GameObject)
                    || generatedType == typeof(Collider)
                    || generatedType == typeof(Collider2D)
                    || generatedType == typeof(Collision)
                    || generatedType == typeof(Collision2D))
                {
                    valueEqualsMethodContent = "return _value == other;";
                }

                solver.template.body +=
$@"
        protected override bool ValueEquals({generatedType.CodeCompatibleFullName()} other)
        {{
            {valueEqualsMethodContent}
        }}
    ";
            }
        }

        public static Template GetTemplate(Type type) => AtomTemplateFactory.GetAssetTemplate(typeof(AtomVariable<>), type, atomName, "atom-icon-lush");
    }
}
