using System;
using System.Collections.Generic;
using UnityEngine;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Internal class used for templating when generating new Atoms using the `Generator`.
    /// </summary>
    internal class Templating
    {
        /// <summary>
        /// Resolve conditionals from the provided tempalte.
        /// </summary>
        /// <param name="template">Template to resolve the conditionals from.</param>
        /// <param name="trueConditions">A list of conditionals that are `true`.</param>
        /// <returns>A new template string resolved and based on the provided `template`.</returns>
        public static string ResolveConditionals(string template, List<string> trueConditions)
        {
            var templateCopy = String.Copy(template);
            templateCopy = templateCopy.Replace("\r\n", "\n");

            var indexIfOpened = templateCopy.LastIndexOf("<%IF ", StringComparison.Ordinal);
            if (indexIfOpened == -1) return templateCopy; // No IF blocks left and nothing else to resolve. Return template.

            var indexIfClosed = templateCopy.IndexOf("%>", indexIfOpened + 5, StringComparison.Ordinal);
            if (indexIfClosed == -1) throw new Exception("Found <%IF block but it was never closed (missing %>)");

            var condition = templateCopy.Substring(indexIfOpened + 5, indexIfClosed - (indexIfOpened + 5));
            var isNegatedCondition = condition.Substring(0, 1) == "!";
            if (isNegatedCondition) { condition = condition.Substring(1); }

            var indexOfNextEndIf = templateCopy.IndexOf("<%ENDIF%>", indexIfClosed, StringComparison.Ordinal);
            if (indexOfNextEndIf == -1) throw new Exception("No closing <%ENDIF%> for condition.");

            // NOTE: We are assuming that when the next char after the conditional is a new line char that it's not inline.
            // However, this is not always true (you can have an inline conditional at the end of a line). This implementation
            // works for our cases for now, but we might need to come back and change this in the future for other use cases.
            var indexOfNextCharAfterEndIf = indexOfNextEndIf + "<%ENDIF%>".Length;
            var indexOfLFAfterEndIf =
                templateCopy.IndexOf("\n", indexOfNextEndIf, StringComparison.Ordinal);
            var inline = true;
            if (indexOfLFAfterEndIf == indexOfNextCharAfterEndIf)
            {
                indexOfNextCharAfterEndIf = indexOfLFAfterEndIf + 1;
                inline = false;
            }

            var indexOfNextElse = templateCopy.IndexOf("<%ELSE%>", indexIfClosed, StringComparison.Ordinal);
            if (indexOfNextElse >= indexOfNextEndIf) indexOfNextElse = -1;

            var endThenBlock = indexOfNextElse != -1 ? indexOfNextElse : indexOfNextEndIf;

            var resolved = "";
            if (trueConditions.Contains(condition) ^ isNegatedCondition)
            {
                resolved = templateCopy.Substring(indexIfClosed + 2, endThenBlock - (indexIfClosed + 2));
            }
            else if (indexOfNextElse != -1)
            {
                resolved = templateCopy.Substring(indexOfNextElse + 8, indexOfNextEndIf - (indexOfNextElse + 8));
            }

            resolved = resolved.Trim('\n');
            templateCopy = templateCopy.Remove(indexIfOpened, indexOfNextCharAfterEndIf - indexIfOpened);
            templateCopy = templateCopy.Insert(indexIfOpened, string.IsNullOrEmpty(resolved) ? "" : $"{resolved}" + (inline ? "" : "\n"));
            return ResolveConditionals(templateCopy, trueConditions);
        }

        /// <summary>
        /// Resolve variables in the provided string.
        /// </summary>
        /// <param name="templateVariables">Dictionay mapping template variables and their resolutions.</param>
        /// <param name="toResolve">The string to resolve.</param>
        /// <returns>A new template string resolved and based on the provided `toResolve` string.</returns>
        public static string ResolveVariables(Dictionary<string, string> templateVariables, string toResolve)
        {
            var resolvedString = toResolve;
            foreach (var kvp in templateVariables)
            {
                resolvedString = resolvedString.Replace("{" + kvp.Key + "}", kvp.Value);
            }
            return resolvedString;
        }
    }
}
