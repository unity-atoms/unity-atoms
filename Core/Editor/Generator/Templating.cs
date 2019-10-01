using System;
using System.Collections.Generic;

namespace UnityAtoms.Editor
{
    internal class Templating
    {
        public static string ResolveConditionals(string template, List<string> trueConditions)
        {
            var templateCopy = String.Copy(template);

            var indexIfOpened = templateCopy.LastIndexOf("<%IF ", StringComparison.Ordinal);
            if (indexIfOpened == -1) return templateCopy; // No IF blocks left and nothing else to resolve. Return template.

            var indexIfClosed = templateCopy.IndexOf("%>", indexIfOpened + 5, StringComparison.Ordinal);
            if (indexIfClosed == -1) throw new Exception("Found <%IF block but it was never closed (missing %>)");

            var condition = templateCopy.Substring(indexIfOpened + 5, indexIfClosed - (indexIfOpened + 5));
            var isNegatedCondition = condition.Substring(0, 1) == "!";
            if (isNegatedCondition) { condition = condition.Substring(1); }

            var indexOfNextEndIf = templateCopy.IndexOf("<%ENDIF%>", indexIfClosed, StringComparison.Ordinal);
            if (indexOfNextEndIf == -1) throw new Exception("No closing <%ENDIF%> for condition.");

            var indexOfNextElse = templateCopy.IndexOf("<%ELSE%>", indexIfClosed, StringComparison.Ordinal);

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
            templateCopy = templateCopy.Remove(indexIfOpened, (indexOfNextEndIf + 9) - indexIfOpened);
            templateCopy = templateCopy.Insert(indexIfOpened, resolved);

            return ResolveConditionals(templateCopy, trueConditions);
        }
    }
}
