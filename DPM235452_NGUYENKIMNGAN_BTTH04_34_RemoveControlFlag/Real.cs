using System;
using System.Collections.Generic;

namespace DPM235452_NGUYENKIMNGAN_BTTH04_34_RemoveControlFlag
{
    // Lớp ghi nhận nhật ký ra vào khu vực
    public class SecurityLog
    {
        public string Location { get; set; }
        public string[] Visitors { get; set; }

        public SecurityLog(string location, string[] visitors)
        {
            Location = location;
            Visitors = visitors;
        }
    }

    public class Real
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            SecurityCheckerAfter checker = new SecurityCheckerAfter();

            // Danh sách khách quét tại các khu vực an ninh
            List<SecurityLog> logs = new List<SecurityLog>
            {
                new SecurityLog("Cổng A - Tầng trệt", new string[] { "Alice", "Bob", "John", "Charlie" }), // Có "John"
                new SecurityLog("Cổng B - Tầng 2", new string[] { "David", "Emma", "Frank" }),              // Khách hợp lệ
                new SecurityLog("Cổng C - Tầng 3", new string[] { "Don", "Grace", "Henry" })                // Có "Don"
            };

            Console.WriteLine("==================================================");
            Console.WriteLine("     HỆ THỐNG KIỂM SOÁT AN NINH RA VÀO TÒA NHÀ    ");
            Console.WriteLine("==================================================\n");

            foreach (var log in logs)
            {
                Console.WriteLine($"Đang quét an ninh tại: {log.Location}...");

                // Gọi kiểm tra an ninh đã được tái cấu trúc loại bỏ cờ điều khiển
                checker.CheckSecurity(log.Visitors);

                Console.WriteLine("--------------------------------------------------");
            }

            Console.WriteLine("\nHoàn tất kiểm tra an ninh.");
            Console.ReadLine();
        }
    }
}