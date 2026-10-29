using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH03_27_ConsolidateDuplicateConditionalFragments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== PATTERN 27: CONSOLIDATE DUPLICATE CONDITIONAL FRAGMENTS ===");

            double price = 1_000_000;

            // 1. BEFORE
            Before before = new Before();
            before.CalculateTotal(isSpecialDeal: true, price: price);

            // 2. AFTER
            After after = new After();
            after.CalculateTotal(isSpecialDeal: true, price: price);

            // 3. REAL
            Real real = new Real();
            real.ProcessOrder(isSpecialDeal: true, price: price);

            Console.ReadLine();
        }
    }
}