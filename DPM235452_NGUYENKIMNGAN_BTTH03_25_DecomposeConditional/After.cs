using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH03_25_DecomposeConditional
{
    public class After
    {
        private static readonly DateTime SummerStart = new DateTime(2026, 6, 1);
        private static readonly DateTime SummerEnd = new DateTime(2026, 8, 31);
        private const double WinterRate = 100.0;
        private const double WinterServiceCharge = 20.0;
        private const double SummerRate = 80.0;

        // Tái cấu trúc: Phân rã biểu thức điều kiện và các nhánh thực thi thành các hàm độc lập có tên gợi nhớ
        public double CalculateCharge(DateTime date, int quantity)
        {
            if (NotSummer(date))
            {
                return WinterCharge(quantity);
            }
            return SummerCharge(quantity);
        }

        private bool NotSummer(DateTime date)
        {
            return date < SummerStart || date > SummerEnd;
        }

        private double WinterCharge(int quantity)
        {
            return quantity * WinterRate + WinterServiceCharge;
        }

        private double SummerCharge(int quantity)
        {
            return quantity * SummerRate;
        }
    }
}