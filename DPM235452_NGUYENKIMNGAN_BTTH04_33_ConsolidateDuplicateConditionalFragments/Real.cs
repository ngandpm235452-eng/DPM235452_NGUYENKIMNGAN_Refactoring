using System;
using System.Collections.Generic;

namespace DPM235452_NGUYENKIMNGAN_BTTH04_33_ConsolidateDuplicateConditionalFragments
{
    // Đối tượng đơn hàng thực tế
    public class CustomerOrder
    {
        public string OrderId { get; set; }
        public string CustomerName { get; set; }
        public double OriginalPrice { get; set; }
        public bool IsVIPCustomer { get; set; }

        public CustomerOrder(string id, string name, double price, bool isVip)
        {
            OrderId = id;
            CustomerName = name;
            OriginalPrice = price;
            IsVIPCustomer = isVip;
        }
    }

    public class Real
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            OrderProcessorAfter processor = new OrderProcessorAfter();

            List<CustomerOrder> orders = new List<CustomerOrder>
            {
                new CustomerOrder("HD001", "Nguyễn Văn A", 1000.0, true),  // Khách VIP (Special Deal)
                new CustomerOrder("HD002", "Trần Thị B", 500.0, false)     // Khách thường
            };

            Console.WriteLine("==================================================");
            Console.WriteLine("    HỆ THỐNG XỬ LÝ VÀ XUẤT HÓA ĐƠN ĐƠN HÀNG       ");
            Console.WriteLine("==================================================\n");

            foreach (var order in orders)
            {
                Console.WriteLine($"Mã đơn: {order.OrderId} | Khách hàng: {order.CustomerName}");
                Console.WriteLine($"  - Giá gốc: ${order.OriginalPrice:N2}");
                Console.WriteLine($"  - Loại KH : {(order.IsVIPCustomer ? "VIP (Giảm 15%)" : "Thường (Giảm 5%)")}");

                // Gọi xử lý tính tiền và gửi thông báo email
                double finalTotal = processor.ProcessOrder(order.OriginalPrice, order.IsVIPCustomer);

                Console.WriteLine($"  -> Tổng thanh toán cuối cùng: ${finalTotal:N2}\n");
            }

            Console.WriteLine("==================================================");
            Console.ReadLine();
        }
    }
}