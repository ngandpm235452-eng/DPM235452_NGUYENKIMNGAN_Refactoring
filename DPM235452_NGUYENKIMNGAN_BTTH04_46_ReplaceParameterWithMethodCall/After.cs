using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH04_46_ReplaceParameterWithMethodCall
{
    public class OrderAfter
    {
        private int _quantity;
        private double _itemPrice;

        public OrderAfter(int quantity, double itemPrice)
        {
            _quantity = quantity;
            _itemPrice = itemPrice;
        }

        public double GetFinalPrice()
        {
            double basePrice = _quantity * _itemPrice;

            // Tái cấu trúc: Bỏ tham số discountLevel, đơn giản hóa lời gọi hàm
            return GetDiscountedPrice(basePrice);
        }

        private int GetDiscountLevel()
        {
            return _quantity > 100 ? 2 : 1;
        }

        private double GetDiscountedPrice(double basePrice)
        {
            // Tự gọi phương thức GetDiscountLevel() bên trong hàm
            if (GetDiscountLevel() == 2) return basePrice * 0.9;
            return basePrice * 0.95;
        }
    }
}