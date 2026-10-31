using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH04_31_DecomposeConditional
{
    public class StadiumTicketAfter
    {
        private static readonly DateTime SummerStart = new DateTime(2026, 6, 1);
        private static readonly DateTime SummerEnd = new DateTime(2026, 8, 31);

        private double winterRate = 100.0;
        private double winterServiceCharge = 20.0;
        private double summerRate = 150.0;

        public double CalculateTicketPrice(DateTime date, int quantity)
        {
            if (IsWinter(date))
            {
                return WinterCharge(quantity);
            }
            else
            {
                return SummerCharge(quantity);
            }
        }

        // 1. Phân rã biểu thức kiểm tra điều kiện thành phương thức riêng
        private bool IsWinter(DateTime date)
        {
            return date < SummerStart || date > SummerEnd;
        }

        // 2. Phân rã nhánh xử lý tính tiền mùa đông
        private double WinterCharge(int quantity)
        {
            return quantity * winterRate + winterServiceCharge;
        }

        // 3. Phân rã nhánh xử lý tính tiền mùa hè
        private double SummerCharge(int quantity)
        {
            return quantity * summerRate;
        }
    }
}