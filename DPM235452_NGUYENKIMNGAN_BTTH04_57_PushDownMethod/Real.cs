using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH04_57_PushDownMethod
{
    public class Real
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            SalesmanAfter salesman = new SalesmanAfter();
            EngineerAfter engineer = new EngineerAfter();

            Console.WriteLine("==================================================");
            Console.WriteLine("    HỆ THỐNG QUẢN LÝ CHỈ TIÊU KINH DOANH         ");
            Console.WriteLine("==================================================\n");

            Console.WriteLine("1. Vị trí Nhân viên Kinh doanh:");
            Console.WriteLine($"  - Chỉ tiêu doanh số (Quota): ${salesman.GetQuota():N2}\n");

            Console.WriteLine("2. Vị trí Kỹ sư Phần mềm:");
            Console.WriteLine("  - Không áp dụng chỉ tiêu doanh số bán hàng.\n");

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Lưu ý: Phương thức GetQuota() đã được đẩy xuống");
            Console.WriteLine("lớp SalesmanAfter, giúp lớp EngineerAfter loại bỏ");
            Console.WriteLine("được phương thức thừa không thuộc về nó.");
            Console.WriteLine("==================================================");

            Console.ReadLine();
        }
    }
}