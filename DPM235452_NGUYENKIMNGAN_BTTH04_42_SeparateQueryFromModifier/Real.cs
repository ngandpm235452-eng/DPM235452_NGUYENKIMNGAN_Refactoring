using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH04_42_SeparateQueryFromModifier
{
    public class Real
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            SecurityCheckerAfter checker = new SecurityCheckerAfter();

            string[] visitorList1 = new string[] { "Alice", "Bob", "John", "Charlie" };
            string[] visitorList2 = new string[] { "David", "Emma", "Frank" };

            Console.WriteLine("==================================================");
            Console.WriteLine("    HỆ THỐNG KIỂM SOÁT AN NINH KHÁCH RA VÀO       ");
            Console.WriteLine("==================================================\n");

            // Có thể gọi hàm Query kiểm tra thông tin bất kỳ lúc nào mà không sợ kích hoạt cảnh báo nhầm
            Console.WriteLine("1. Quét danh sách 1...");
            string foundPerson1 = checker.FoundMiscreant(visitorList1);
            Console.WriteLine($"  - Kết quả kiểm tra: {(string.IsNullOrEmpty(foundPerson1) ? "An toàn" : "Phát hiện đối tượng: " + foundPerson1)}");

            // Chủ động kích hoạt xử lý cảnh báo (Modifier) khi thực sự cần thiết
            if (!string.IsNullOrEmpty(foundPerson1))
            {
                Console.Write("  - Thực thi quy trình an ninh: ");
                checker.SendAlert(visitorList1);
            }

            Console.WriteLine("\n2. Quét danh sách 2...");
            string foundPerson2 = checker.FoundMiscreant(visitorList2);
            Console.WriteLine($"  - Kết quả kiểm tra: {(string.IsNullOrEmpty(foundPerson2) ? "An toàn" : "Phát hiện đối tượng: " + foundPerson2)}");

            Console.WriteLine("\n==================================================");
            Console.ReadLine();
        }
    }
}