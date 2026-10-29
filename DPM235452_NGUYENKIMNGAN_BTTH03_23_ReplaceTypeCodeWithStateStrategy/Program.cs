using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH03_23_ReplaceTypeCodeWithStateStrategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== PATTERN 23: REPLACE TYPE CODE WITH STATE/STRATEGY ===");

            // 1. BEFORE (Đổi mã int trực tiếp ở runtime)
            Before before = new Before();
            Console.WriteLine($"[BEFORE] Lương sau khi đổi thành Manager: {before.Calculate():N0} VNĐ");

            // 2. AFTER (Đổi đối tượng State/Strategy ở runtime)
            After after = new After();
            Console.WriteLine($"[AFTER] Lương sau khi chuyển sang ManagerAfter: {after.Calculate():N0} VNĐ");

            // 3. REAL (Thay đổi chức vụ động với Validation)
            Real real = new Real();
            var employee = real.CreateEmployee("Nguyen Kim Ngan", 15_000_000, new EngineerRoleReal());
            Console.WriteLine($"[REAL] Ban đầu: {employee.Name} - Chức vụ: {employee.RoleStrategy.RoleName} | Lương: {employee.CalculateTotalPay():N0} VNĐ");

            // Thăng chức lên Quản lý lúc Runtime
            employee.RoleStrategy = new ManagerRoleReal();
            employee.SetBonus(5_000_000);
            Console.WriteLine($"[REAL] Thăng chức: {employee.Name} - Chức vụ: {employee.RoleStrategy.RoleName} | Lương: {employee.CalculateTotalPay():N0} VNĐ");

            Console.ReadLine();
        }
    }
}