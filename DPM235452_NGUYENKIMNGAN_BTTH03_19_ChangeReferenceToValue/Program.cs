using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH03_19_ChangeReferenceToValue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== PATTERN 19: CHANGE REFERENCE TO VALUE ===");

            // 1. BEFORE (Thay đổi dữ liệu qua mutable reference làm hỏng dữ liệu dùng chung)
            CurrencyBefore sharedCurrency = new CurrencyBefore("USD");
            Before item1Before = new Before(sharedCurrency);
            Before item2Before = new Before(sharedCurrency);
            item1Before.Currency.Code = "VND"; // Sửa ở item1 vô tình làm thay đổi item2
            Console.WriteLine($"[BEFORE] Item 2 Currency bị đổi ngoài ý muốn: {item2Before.Currency.Code}");

            // 2. AFTER (Immutable Value Object - so sánh giá trị an toàn)
            CurrencyAfter c1After = new CurrencyAfter("USD");
            CurrencyAfter c2After = new CurrencyAfter("USD");
            After after = new After(c1After);
            Console.WriteLine($"[AFTER] Hai đối tượng giá trị USD độc lập có bằng nhau không? {c1After.Equals(c2After)}");

            // 3. REAL (Value Object chuẩn hóa dữ liệu, nạp chồng toán tử ==)
            CurrencyReal vnd1 = new CurrencyReal("vnd");
            CurrencyReal vnd2 = new CurrencyReal("VND");
            Real realItem = new Real(150000, vnd1);
            Console.WriteLine($"[REAL] So sánh hai giá trị VND (operator ==): {vnd1 == vnd2} | Mã chuẩn: {realItem.Currency.Code}");

            Console.ReadLine();
        }
    }
}