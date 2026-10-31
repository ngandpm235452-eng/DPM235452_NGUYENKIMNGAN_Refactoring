using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH04_31_DecomposeConditional
{
    public class StadiumTicketBefore
    {
        private static readonly DateTime SummerStart = new DateTime(2026, 6, 1);
        private static readonly DateTime SummerEnd = new DateTime(2026, 8, 31);

        private double winterRate = 100.0;
        private double winterServiceCharge = 20.0;
        private double summerRate = 150.0;

        public double CalculateTicketPrice(DateTime date, int quantity)
        {
            double charge;
            // Biểu thức điều kiện phức tạp kết hợp trực tiếp với công thức tính toán
            if (date < SummerStart || date > SummerEnd)
            {
                charge = quantity * winterRate + winterServiceCharge;
            }
            else
            {
                charge = quantity * summerRate;
            }
            return charge;
        }
    }
}