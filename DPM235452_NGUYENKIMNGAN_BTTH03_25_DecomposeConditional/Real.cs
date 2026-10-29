using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH03_25_DecomposeConditional
{
    // Ứng dụng thực tế: Đóng gói bảng giá qua Constructor, bảo vệ dữ liệu với Validation và tách biệt logic kiểm tra điều kiện
    public class Real
    {
        private readonly DateTime _summerStart = new DateTime(2026, 6, 1);
        private readonly DateTime _summerEnd = new DateTime(2026, 8, 31);
        private readonly double _winterRate;
        private readonly double _winterServiceCharge;
        private readonly double _summerRate;

        public Real(double winterRate = 100.0, double winterServiceCharge = 20.0, double summerRate = 80.0)
        {
            if (winterRate < 0 || summerRate < 0 || winterServiceCharge < 0)
                throw new ArgumentOutOfRangeException("Đơn giá và phí dịch vụ không được nhỏ hơn 0.");

            _winterRate = winterRate;
            _winterServiceCharge = winterServiceCharge;
            _summerRate = summerRate;
        }

        public double CalculateCharge(DateTime date, int quantity)
        {
            if (quantity < 0)
                throw new ArgumentOutOfRangeException(nameof(quantity), "Số lượng sản phẩm/dịch vụ không được nhỏ hơn 0.");

            return IsSummer(date) ? SummerCharge(quantity) : WinterCharge(quantity);
        }

        private bool IsSummer(DateTime date)
        {
            return date >= _summerStart && date <= _summerEnd;
        }

        private double WinterCharge(int quantity)
        {
            return quantity * _winterRate + _winterServiceCharge;
        }

        private double SummerCharge(int quantity)
        {
            return quantity * _summerRate;
        }
    }
}