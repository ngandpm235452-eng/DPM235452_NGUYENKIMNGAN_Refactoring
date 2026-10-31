using System;
using System.Collections.Generic;

namespace DPM235452_NGUYENKIMNGAN_BTTH04_41_RemoveParameter
{
    public class Order
    {
        public string OrderId { get; set; }
        public string CustomerName { get; set; }
        public double OriginalPrice { get; set; }

        public Order(string id, string name, double price)
        {
            OrderId = id;
            CustomerName = name;
            OriginalPrice = price;
        }
    }

    public class Real
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            CustomerDiscountAfter discountService = new CustomerDiscountAfter();

            List<Order> orders = new List<Order>
            {
                new Order("DH001", "Nguyễn Văn A", 1200.0),
                new Order("DH002", "Trần Thị B", 850.0)
            };

            Console.WriteLine("==================================================");
            Console.WriteLine("   HỆ THỐNG TÍNH GIẢM GIÁ ĐƠN HÀNG KHÁCH HÀNG     ");
            Console.WriteLine("==================================================\n");

            foreach (var order in orders)
            {
                // Gọi phương thức đã lược bỏ tham số thừa, mã nguồn sạch và rõ ràng hơn
                double discount = discountService.CalculateDiscount(order.OriginalPrice);
                double finalPrice = order.OriginalPrice - discount;

                Console.WriteLine($"Mã đơn hàng : {order.OrderId}");
                Console.WriteLine($"  - Khách hàng : {order.CustomerName}");
                Console.WriteLine($"  - Giá gốc    : ${order.OriginalPrice:N2}");
                Console.WriteLine($"  - Giảm giá   : ${discount:N2}");
                Console.WriteLine($"  -> Giá sau giảm: ${finalPrice:N2}\n");
            }

            Console.WriteLine("==================================================");
            Console.ReadLine();
        }
    }
}