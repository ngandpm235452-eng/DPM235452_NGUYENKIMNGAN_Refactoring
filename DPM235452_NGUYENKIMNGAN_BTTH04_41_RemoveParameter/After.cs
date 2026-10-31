using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH04_41_RemoveParameter
{
    public class CustomerDiscountAfter
    {
        // Tái cấu trúc: Loại bỏ tham số customerAge không còn cần thiết
        public double CalculateDiscount(double price)
        {
            double discountRate = 0.10;
            return price * discountRate;
        }
    }
}