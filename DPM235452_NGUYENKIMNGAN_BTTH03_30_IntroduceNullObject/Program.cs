using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH03_30_IntroduceNullObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== PATTERN 30: INTRODUCE NULL OBJECT ===");

            // 1. BEFORE
            Before before = new Before();
            Console.WriteLine($"[BEFORE] Khách null: {before.GetCustomerPlanName(null)}");

            // 2. AFTER
            After after = new After();
            Console.WriteLine($"[AFTER] Khách vãng lai: {after.GetCustomerPlanName(new NullCustomerAfter())}");

            // 3. REAL
            Real real = new Real();
            ICustomerReal vipCustomer = new CustomerReal("Nguyen Kim Ngan", "VIP");
            ICustomerReal nullCustomer = null;

            Console.WriteLine($"[REAL] VIP: {real.GetBillingSummary(vipCustomer)}");
            Console.WriteLine($"[REAL] NULL: {real.GetBillingSummary(nullCustomer)}");

            Console.WriteLine("\n========================================================");
            Console.WriteLine("🎉 CHÚC MỪNG BẠN ĐÃ HOÀN THÀNH TOÀN BỘ 30/30 PATTERNS REFACTORING! 🎉");
            Console.WriteLine("========================================================");

            Console.ReadLine();
        }
    }
}