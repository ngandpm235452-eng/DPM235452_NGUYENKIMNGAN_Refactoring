using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH03_27_ConsolidateDuplicateConditionalFragments
{
    // Ứng dụng thực tế: Đóng gói tỷ lệ chiết khấu, kiểm tra ràng buộc giá trị dữ liệu đầu vào và tối ưu hóa biểu thức gán điều kiện
    public class Real
    {
        private readonly double _specialDiscountRate;
        private readonly double _regularDiscountRate;

        public Real(double specialDiscountRate = 0.10, double regularDiscountRate = 0.05)
        {
            if (specialDiscountRate < 0 || specialDiscountRate > 1)
                throw new ArgumentOutOfRangeException(nameof(specialDiscountRate), "Tỷ lệ giảm giá đặc biệt phải nằm trong khoảng từ 0 đến 1.");
            if (regularDiscountRate < 0 || regularDiscountRate > 1)
                throw new ArgumentOutOfRangeException(nameof(regularDiscountRate), "Tỷ lệ giảm giá thông thường phải nằm trong khoảng từ 0 đến 1.");

            _specialDiscountRate = specialDiscountRate;
            _regularDiscountRate = regularDiscountRate;
        }

        public double ProcessOrder(bool isSpecialDeal, double price)
        {
            if (price <= 0)
                throw new ArgumentOutOfRangeException(nameof(price), "Giá đơn hàng phải lớn hơn 0.");

            double discountRate = isSpecialDeal ? _specialDiscountRate : _regularDiscountRate;
            double total = price * (1.0 - discountRate);

            SendInvoice(total);
            return total;
        }

        private void SendInvoice(double total)
        {
            Console.WriteLine($"[REAL] Hóa đơn điện tử khởi tạo thành công với số tiền thanh toán: {total:N0} VNĐ");
        }
    }
}