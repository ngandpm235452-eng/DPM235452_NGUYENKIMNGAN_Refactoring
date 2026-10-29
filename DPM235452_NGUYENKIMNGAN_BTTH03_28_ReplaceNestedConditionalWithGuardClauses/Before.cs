using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH03_28_ReplaceNestedConditionalWithGuardClauses
{
    public class Before
    {
        public double GetPayAmount(bool isDead, bool isSeparated, bool isRetired)
        {
            double result;
            // Code Smell: Nested Conditionals - Các câu lệnh if-else lồng nhau nhiều tầng gầy rối luồng thực thi (Arrow Anti-pattern)
            if (isDead)
            {
                result = DeadAmount();
            }
            else
            {
                if (isSeparated)
                {
                    result = SeparatedAmount();
                }
                else
                {
                    if (isRetired)
                    {
                        result = RetiredAmount();
                    }
                    else
                    {
                        result = NormalPayAmount();
                    }
                }
            }
            return result;
        }

        private double DeadAmount() => 5000.0;
        private double SeparatedAmount() => 2000.0;
        private double RetiredAmount() => 3000.0;
        private double NormalPayAmount() => 1000.0;
    }
}