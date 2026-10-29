using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH03_29_ReplaceConditionalWithPolymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== PATTERN 29: REPLACE CONDITIONAL WITH POLYMORPHISM ===");

            // 1. BEFORE
            Before before = new Before();
            Console.WriteLine($"[BEFORE] Tốc độ chim Châu Âu: {before.CalculateSpeed(BirdBefore.EUROPEAN)}");

            // 2. AFTER
            After after = new After();
            Console.WriteLine($"[AFTER] Tốc độ chim Châu Âu: {after.CalculateEuropeanSpeed()}");

            // 3. REAL
            Real real = new Real();
            ShippingCalculatorReal express = new ExpressShippingReal(baseWeight: 2.5);
            ShippingCalculatorReal sameDay = new SameDayShippingReal(baseWeight: 2.5, isDistanceOver20Km: true);

            Console.WriteLine($"[REAL] Phí giao hàng hỏa tốc (Express): {real.CalculateCost(express):N0} VNĐ");
            Console.WriteLine($"[REAL] Phí giao trong ngày (SameDay > 20km): {real.CalculateCost(sameDay):N0} VNĐ");

            Console.ReadLine();
        }
    }
}