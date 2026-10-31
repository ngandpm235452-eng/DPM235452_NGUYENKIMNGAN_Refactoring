using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH04_49_HideMethod
{
    public class RateCalculatorAfter
    {
        // Tái cấu trúc: Giảm phạm vi truy cập thành private, bảo vệ logic tính toán nội bộ
        private double CalculateDiscount(double amount)
        {
            return amount * 0.05;
        }

        public double GetFinalRate(double baseRate, double amount)
        {
            return baseRate - CalculateDiscount(amount);
        }
    }
}