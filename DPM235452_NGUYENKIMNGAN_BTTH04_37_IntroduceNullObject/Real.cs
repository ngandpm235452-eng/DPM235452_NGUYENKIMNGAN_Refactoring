using System;
using System.Collections.Generic;

namespace DPM235452_NGUYENKIMNGAN_BTTH04_37_IntroduceNullObject
{
    public class Real
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            CustomerServiceAfter service = new CustomerServiceAfter();

            // Danh sách khách hàng (có người đăng ký gói, có người không/null)
            List<CustomerAfter> customers = new List<CustomerAfter>
            {
                new CustomerAfter("Nguyễn Văn A", new RealPlan("Gói VIP Premium")),
                new CustomerAfter("Trần Thị B", null), // Không đăng ký -> Nhận NullPlan
                new CustomerAfter("Lê Văn C", new RealPlan("Gói Doanh Nghiệp"))
            };

            Console.WriteLine("==================================================");
            Console.WriteLine("    HỆ THỐNG QUẢN LÝ GÓI DỊCH VỤ KHÁCH HÀNG       ");
            Console.WriteLine("==================================================\n");

            foreach (var cust in customers)
            {
                Console.WriteLine($"Khách hàng: {cust.Name}");
                Console.Write("  - ");

                // Gọi phương thức hiển thị mà không bao giờ lo bị NullReferenceException
                service.DisplayCustomerPlan(cust);

                Console.WriteLine($"  - Phân loại  : {(cust.Plan.IsNull ? "[Null Object] Khách hàng dùng mặc định" : "[Real Object] Khách hàng trả phí")}\n");
            }

            Console.WriteLine("==================================================");
            Console.ReadLine();
        }
    }
}