using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH03_26_ConsolidateConditionalExpression
{
    public class Before
    {
        public int Seniority { get; set; } = 1;
        public int MonthsDisabled { get; set; } = 0;
        public bool IsPartTime { get; set; } = false;

        public double CalculateDisabilityAmount()
        {
            // Code Smell: Multiple Conditional Checks - Nhiều câu lệnh if riêng biệt cùng dẫn đến một kết quả trả về (0)
            if (Seniority < 2) return 0;
            if (MonthsDisabled > 12) return 0;
            if (IsPartTime) return 0;

            return 500.0;
        }
    }
}