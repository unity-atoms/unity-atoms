using System;

namespace UnityAtoms.Conditions
{
    [Serializable]
    public class IntCondition : BaseCondition
    {
        public IntReference Reference;
        public MathComparison ComparisonType = MathComparison.Equals;
        public IntReference Value;

        public override bool IsTrue()
        {
            switch (ComparisonType)
            {
                case MathComparison.Equals:
                    return Reference.Value == Value;
                case MathComparison.NotEquals:
                    return Reference.Value != Value;
                case MathComparison.Greater:
                    return Reference.Value > Value;
                case MathComparison.GreaterOrEquals:
                    return Reference.Value >= Value;
                case MathComparison.Less:
                    return Reference.Value < Value;
                case MathComparison.LessOrEquals:
                    return Reference.Value <= Value;
                default:
                    throw new NotImplementedException("Comparison couldn't be made because the comparison type is not valid!");
            }
        }
    }
}
