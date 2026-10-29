using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH03_28_ReplaceNestedConditionalWithGuardClauses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== PATTERN 28: REPLACE NESTED CONDITIONAL WITH GUARD CLAUSES ===");

            // 1. BEFORE
            Before before = new Before();
            Console.WriteLine($"[BEFORE] Số tiền chi trả (Nghỉ hưu): {before.GetPayAmount(isDead: false, isSeparated: false, isRetired: true):N0} VNĐ");

            // 2. AFTER
            After after = new After();
            Console.WriteLine($"[AFTER] Số tiền chi trả (Nghỉ hưu): {after.GetPayAmount(isDead: false, isSeparated: false, isRetired: true):N0} VNĐ");

            // 3. REAL
            Real real = new Real();
            double payout = real.CalculatePayout(EmployeeStatus.Retired, baseSalary: 10_000_000, yearsOfService: 15);
            Console.WriteLine($"[REAL] Trợ cấp nghỉ hưu thực tế: {payout:N0} VNĐ");

            Console.ReadLine();
        }
    }
}