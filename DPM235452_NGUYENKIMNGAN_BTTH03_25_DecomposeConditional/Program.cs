using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH03_25_DecomposeConditional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== PATTERN 25: DECOMPOSE CONDITIONAL ===");

            DateTime summerDate = new DateTime(2026, 7, 15);
            DateTime winterDate = new DateTime(2026, 12, 20);
            int quantity = 10;

            // 1. BEFORE
            Before before = new Before();
            Console.WriteLine($"[BEFORE] Cước mùa hè: {before.CalculateCharge(summerDate, quantity):N0} VNĐ");
            Console.WriteLine($"[BEFORE] Cước mùa đông: {before.CalculateCharge(winterDate, quantity):N0} VNĐ");

            // 2. AFTER
            After after = new After();
            Console.WriteLine($"[AFTER] Cước mùa hè: {after.CalculateCharge(summerDate, quantity):N0} VNĐ");
            Console.WriteLine($"[AFTER] Cước mùa đông: {after.CalculateCharge(winterDate, quantity):N0} VNĐ");

            // 3. REAL
            Real real = new Real();
            Console.WriteLine($"[REAL] Cước mùa hè chuẩn: {real.CalculateCharge(summerDate, quantity):N0} VNĐ");
            Console.WriteLine($"[REAL] Cước mùa đông chuẩn: {real.CalculateCharge(winterDate, quantity):N0} VNĐ");

            Console.ReadLine();
        }
    }
}