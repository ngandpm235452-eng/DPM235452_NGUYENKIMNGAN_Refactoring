using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH03_30_IntroduceNullObject
{
    // Ứng dụng thực tế: Thiết kế Interface, Null Object dạng Singleton (thread-safe), kiểm tra dữ liệu đầu vào và đóng gói tính toán chiết khấu
    public interface ICustomerReal
    {
        string Name { get; }
        string Plan { get; }
        bool IsNull { get; }
        double GetDiscountRate();
    }

    public class CustomerReal : ICustomerReal
    {
        public string Name { get; }
        public string Plan { get; }
        public bool IsNull => false;

        public CustomerReal(string name, string plan)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Tên khách hàng không được để trống.", nameof(name));
            if (string.IsNullOrWhiteSpace(plan))
                throw new ArgumentException("Gói dịch vụ không được để trống.", nameof(plan));

            Name = name.Trim();
            Plan = plan.Trim();
        }

        public double GetDiscountRate() => Plan.Equals("VIP", StringComparison.OrdinalIgnoreCase) ? 0.20 : 0.05;
    }

    public sealed class NullCustomerReal : ICustomerReal
    {
        public static NullCustomerReal Instance { get; } = new NullCustomerReal();

        public string Name => "Khách vãng lai";
        public string Plan => "Không có đăng ký";
        public bool IsNull => true;

        private NullCustomerReal() { }

        public double GetDiscountRate() => 0.0;
    }

    public class Real
    {
        public string GetBillingSummary(ICustomerReal customer)
        {
            // Loại bỏ hoàn toàn nguy cơ NullReferenceException
            ICustomerReal activeCustomer = customer ?? NullCustomerReal.Instance;
            return $"Khách hàng: {activeCustomer.Name} | Gói: {activeCustomer.Plan} | Chiết khấu: {activeCustomer.GetDiscountRate() * 100}%";
        }
    }
}