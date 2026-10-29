using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH03_18_ChangeValueToReference
{
    public class Customer
    {
        public string Name { get; }
        public Customer(string name)
        {
            Name = name;
        }
    }

    public class Before
    {
        // Code Smell: Duplicate Value Objects - Mỗi đơn hàng đều tự tạo mới (new) một đối tượng Customer riêng lẻ, gây lãng phí bộ nhớ và bất đồng bộ dữ liệu nếu khách hàng thay đổi thông tin
        public Customer Customer { get; }

        public Before(string customerName)
        {
            Customer = new Customer(customerName);
        }
    }
}