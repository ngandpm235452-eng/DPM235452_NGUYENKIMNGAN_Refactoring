using System;
using System.Collections.Generic;

namespace DPM235452_NGUYENKIMNGAN_BTTH04_55_PullUpMethod
{
    public class Real
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            List<CustomerAfter> customers = new List<CustomerAfter>
            {
                new RegularCustomerAfter(),
                new VipCustomerAfter()
            };

            Console.WriteLine("==================================================");
            Console.WriteLine("    HỆ THỐNG TÍNH ĐIỂM THƯỞNG KHÁCH HÀNG          ");
            Console.WriteLine("==================================================\n");

            double purchaseAmount = 500.0;

            foreach (var cust in customers)
            {
                string type = cust is VipCustomerAfter ? "Khách hàng VIP" : "Khách hàng Thường";

                // Gọi phương thức CalculatePoints được thừa kế từ lớp cha CustomerAfter
                int points = cust.CalculatePoints(purchaseAmount);

                Console.WriteLine($"Loại tài khoản : {type}");
                Console.WriteLine($"  - Giá trị đơn  : ${purchaseAmount:N2}");
                Console.WriteLine($"  - Điểm tích lũy: {points} điểm\n");
            }

            Console.WriteLine("==================================================");
            Console.ReadLine();
        }
    }
}