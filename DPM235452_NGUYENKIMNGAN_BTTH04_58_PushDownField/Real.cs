using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH04_58_PushDownField
{
    public class Real
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            SalesmanAfter salesman = new SalesmanAfter();
            salesman.SetQuota(5000.0);

            EngineerAfter engineer = new EngineerAfter();

            Console.WriteLine("==================================================");
            Console.WriteLine("    HỆ THỐNG QUẢN LÝ DỮ LIỆU CHỈ TIÊU BÁN HÀNG   ");
            Console.WriteLine("==================================================\n");

            Console.WriteLine("1. Nhân viên Kinh doanh:");
            Console.WriteLine($"  - Mức chỉ tiêu (Quota): ${salesman.GetQuota():N2}\n");

            Console.WriteLine("2. Kỹ sư Phần mềm:");
            Console.WriteLine("  - Không giữ trường dữ liệu Quota trong bộ nhớ.\n");

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Lưu ý: Trường dữ liệu _quota đã được đẩy xuống");
            Console.WriteLine("lớp SalesmanAfter, giúp tối ưu hóa cấu trúc dữ liệu");
            Console.WriteLine("cho các lớp con không cần đến nó.");
            Console.WriteLine("==================================================");

            Console.ReadLine();
        }
    }
}