using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH04_41_RemoveParameter
{
    public class CustomerDiscountBefore
    {
        // Tham số customerAge không còn được sử dụng trong thân hàm nhưng vẫn bị truyền vào gây dư thừa
        public double CalculateDiscount(double price, int customerAge)
        {
            // Chính sách mới áp dụng mức giảm giá cố định 10% cho mọi đơn hàng
            double discountRate = 0.10;
            return price * discountRate;
        }
    }
}