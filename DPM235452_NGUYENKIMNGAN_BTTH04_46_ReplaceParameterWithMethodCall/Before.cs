using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH04_46_ReplaceParameterWithMethodCall
{
    public class OrderBefore
    {
        private int _quantity;
        private double _itemPrice;

        public OrderBefore(int quantity, double itemPrice)
        {
            _quantity = quantity;
            _itemPrice = itemPrice;
        }

        public double GetFinalPrice()
        {
            double basePrice = _quantity * _itemPrice;

            // Lấy cấp độ giảm giá
            int discountLevel = GetDiscountLevel();

            // Vi phạm: Truyền discountLevel làm tham số trong khi hàm GetDiscountedPrice có thể tự gọi GetDiscountLevel()
            return GetDiscountedPrice(basePrice, discountLevel);
        }

        private int GetDiscountLevel()
        {
            return _quantity > 100 ? 2 : 1;
        }

        private double GetDiscountedPrice(double basePrice, int discountLevel)
        {
            if (discountLevel == 2) return basePrice * 0.9;
            return basePrice * 0.95;
        }
    }
}