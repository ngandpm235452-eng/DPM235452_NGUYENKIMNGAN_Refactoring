using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH03_20_ReplaceArrayWithObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== PATTERN 20: REPLACE ARRAY WITH OBJECT ===");

            // 1. BEFORE (Đọc qua vị trí chỉ số mảng row[0], row[1])
            Before before = new Before();
            string[] row = before.GetPerformanceData();
            Console.WriteLine($"[BEFORE] Tên đội: {row[0]} | Số trận thắng: {row[1]}");

            // 2. AFTER (Đọc qua thuộc tính lớp PerformanceAfter)
            After after = new After();
            PerformanceAfter perfAfter = after.GetPerformanceData();
            Console.WriteLine($"[AFTER] Tên đội: {perfAfter.Name} | Số trận thắng: {perfAfter.Wins}");

            // 3. REAL (Strongly-typed, kiểm tra logic trong Constructor)
            Real real = new Real();
            PerformanceReal perfReal = real.GetPerformanceData();
            Console.WriteLine($"[REAL] Tên đội: {perfReal.TeamName} | Số trận thắng: {perfReal.Wins}");

            Console.ReadLine();
        }
    }
}