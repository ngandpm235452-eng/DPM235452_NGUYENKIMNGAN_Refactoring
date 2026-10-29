using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH03_24_ReplaceSubclassWithFields
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== PATTERN 24: REPLACE SUBCLASS WITH FIELDS ===");

            // 1. BEFORE (Tạo qua lớp con MaleBefore)
            Before before = new Before();
            var maleBefore = before.CreateMale();
            Console.WriteLine($"[BEFORE] Nam - Code: {maleBefore.Code}, IsMale: {maleBefore.IsMale}");

            // 2. AFTER (Dùng trực tiếp PersonAfter với thuộc tính dữ liệu)
            After after = new After();
            var maleAfter = after.CreateMale();
            Console.WriteLine($"[AFTER] Nam - Code: {maleAfter.Code}, IsMale: {maleAfter.IsMale}");

            // 3. REAL (Sử dụng Enum & Validation)
            Real real = new Real();
            var personReal = real.CreatePerson("Nguyen Kim Ngan", Gender.Female);
            Console.WriteLine($"[REAL] {personReal.Name} - Giới tính: {personReal.Gender} (Code: {personReal.GenderCode})");

            Console.ReadLine();
        }
    }
}