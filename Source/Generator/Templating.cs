using System;
using System.Collections.Generic;
using UnityEngine;

namespace UnityAtoms.Editor
{
    internal class Templating
    {
        public static string ResolveConditionals(string template, List<string> trueConditions = null)
        {
            var templateCopy = String.Copy(template);

            while (true && trueConditions != null)
            {
                var indexOfIf = templateCopy.IndexOf("<%IF");

                if (indexOfIf == -1)
                {
                    break;
                }

                var indexOfEndOfIf = templateCopy.IndexOf("\n", indexOfIf) + 1;
                var indexOfNextElse = templateCopy.IndexOf("<%ELSE%>");
                var indexOfEndOfNextElse = templateCopy.IndexOf("\n", indexOfNextElse) + 1;
                var indexOfNextEndIf = templateCopy.IndexOf("<%ENDIF%>");
                var indexOfEndOfNextEndIf = templateCopy.IndexOf("\n", indexOfNextEndIf) + 1;
                var containsElseStatement = indexOfNextElse != -1 && indexOfNextElse < indexOfNextEndIf;
                var condition = templateCopy.Substring(indexOfIf + 5, templateCopy.IndexOf("%>", indexOfIf) - 2 - (indexOfIf + 5));
                var isNegatedCondition = condition.Substring(0, 1) == "!";
                if (isNegatedCondition) { condition = condition.Substring(1); }

                if (indexOfNextEndIf == -1)
                {
                    throw new Exception($"No closing <%ENDIF%> for condition {condition}.");
                }

                if ((!isNegatedCondition && trueConditions.Contains(condition)) || (isNegatedCondition && !trueConditions.Contains(condition)))
                {
                    // Remove if statement
                    int lastRemoveCount, nextRemoveCount;
                    lastRemoveCount = nextRemoveCount = indexOfEndOfIf - indexOfIf;
                    templateCopy = templateCopy.Remove(indexOfIf, nextRemoveCount);

                    // Remove everything after if block
                    templateCopy = containsElseStatement ?
                        templateCopy.Remove(indexOfNextElse - lastRemoveCount, indexOfEndOfNextEndIf - indexOfNextElse) :
                        templateCopy.Remove(indexOfNextEndIf - lastRemoveCount, indexOfEndOfNextEndIf - indexOfNextEndIf);
                }
                else if (containsElseStatement)
                {
                    // Remove if block and else statement
                    int lastRemoveCount, nextRemoveCount;
                    lastRemoveCount = nextRemoveCount = indexOfEndOfNextElse - indexOfIf;
                    templateCopy = templateCopy.Remove(indexOfIf, nextRemoveCount);

                    // Remove ENDIF statement
                    nextRemoveCount = indexOfEndOfNextEndIf - indexOfNextEndIf;
                    templateCopy = templateCopy.Remove(indexOfNextEndIf - lastRemoveCount, nextRemoveCount);
                }
                else
                {
                    // Remove full if / else block
                    var nextRemoveCount = indexOfEndOfNextEndIf - indexOfIf;
                    templateCopy = templateCopy.Remove(indexOfIf, nextRemoveCount);
                }
            }

            return templateCopy;
        }
    }
}
