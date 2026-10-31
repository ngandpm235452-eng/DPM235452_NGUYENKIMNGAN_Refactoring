using System;
using System.Collections.Generic;

namespace DPM235452_NGUYENKIMNGAN_BTTH04_59_ExtractSubclass
{
    public class Real
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            EmployeeAfter tech = new EmployeeAfter(50); // Mức lương nhân công $50/giờ

            List<JobItemAfter> jobItems = new List<JobItemAfter>
            {
                new JobItemAfter(100, 2),            // Hạng mục vật tư: 2 sản phẩm x $100
                new LaborItemAfter(8, tech)          // Hạng mục nhân công: 8 giờ x $50
            };

            Console.WriteLine("==================================================");
            Console.WriteLine("    HỆ THỐNG TÍNH CHI PHÍ DỰ ÁN VÀ THI CÔNG       ");
            Console.WriteLine("==================================================\n");

            int grandTotal = 0;
            foreach (var item in jobItems)
            {
                string itemType = item.IsLabor ? "Thi công Nhân công" : "Vật tư Thiết bị";
                int total = item.GetTotalPrice();
                grandTotal += total;

                Console.WriteLine($"Hạng mục      : {itemType}");
                Console.WriteLine($"  - Số lượng  : {item.Quantity}");
                Console.WriteLine($"  - Đơn giá   : ${item.GetUnitPrice():N0}");
                Console.WriteLine($"  -> Thành tiền: ${total:N0}\n");
            }

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine($"TỔNG CHI PHÍ THI CÔNG DỰ ÁN: ${grandTotal:N0}");
            Console.WriteLine("==================================================");

            Console.ReadLine();
        }
    }
}