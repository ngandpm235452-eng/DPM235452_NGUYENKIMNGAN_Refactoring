using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH03_25_DecomposeConditional
{
    public class Before
    {
        private static readonly DateTime SummerStart = new DateTime(2026, 6, 1);
        private static readonly DateTime SummerEnd = new DateTime(2026, 8, 31);
        private const double WinterRate = 100.0;
        private const double WinterServiceCharge = 20.0;
        private const double SummerRate = 80.0;

        public double CalculateCharge(DateTime date, int quantity)
        {
            double charge;
            // Code Smell: Complex Conditional - Biểu thức điều kiện phức tạp nằm lồng trong nhánh if-else gây khó đọc hiểu ý nghĩa nghiệp vụ
            if (date < SummerStart || date > SummerEnd)
            {
                charge = quantity * WinterRate + WinterServiceCharge;
            }
            else
            {
                charge = quantity * SummerRate;
            }
            return charge;
        }
    }
}
