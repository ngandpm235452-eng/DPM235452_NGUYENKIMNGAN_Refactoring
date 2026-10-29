using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH03_22_ReplaceTypeCodeWithSubclasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== PATTERN 22: REPLACE TYPE CODE WITH SUBCLASSES ===");

            // 1. BEFORE (Sử dụng switch-case theo mã int)
            Before before = new Before();
            Console.WriteLine($"[BEFORE] Lương Engineer: {before.GetEngineerPay():N0} VNĐ");

            // 2. AFTER (Sử dụng đa hình qua lớp con)
            After after = new After();
            Console.WriteLine($"[AFTER] Lương Engineer: {after.GetEngineerPay():N0} VNĐ");

            // 3. REAL (Sử dụng Factory, Enum & Validation)
            Real real = new Real();
            var engineer = real.CreateEmployee(EmployeeTypeReal.Engineer, "Nguyen Kim Ngan", 15000000);
            var manager = real.CreateEmployee(EmployeeTypeReal.Manager, "Tran Van B", 20000000, 5000000);

            Console.WriteLine($"[REAL] {engineer.Name} (Engineer) - Tổng lương: {engineer.CalculateTotalPay():N0} VNĐ");
            Console.WriteLine($"[REAL] {manager.Name} (Manager) - Tổng lương: {manager.CalculateTotalPay():N0} VNĐ");

            Console.ReadLine();
        }
    }
}