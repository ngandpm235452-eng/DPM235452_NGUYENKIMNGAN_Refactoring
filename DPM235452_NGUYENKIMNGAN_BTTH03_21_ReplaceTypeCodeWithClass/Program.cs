using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH03_21_ReplaceTypeCodeWithClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== PATTERN 21: REPLACE TYPE CODE WITH CLASS ===");

            // 1. BEFORE (Truyền mã số nguyên thô)
            Before before = new Before();
            var personBefore = before.CreatePerson();
            Console.WriteLine($"[BEFORE] Nhóm máu (Mã int): {personBefore.BloodGroup}");

            // 2. AFTER (Sử dụng đối tượng BloodGroupAfter - ép kiểu an toàn lúc biên dịch)
            After after = new After();
            var personAfter = after.CreatePerson();
            Console.WriteLine($"[AFTER] Nhóm máu (Class Code): {personAfter.BloodGroup.Code}");

            // 3. REAL (Khởi tạo nâng cao có kiểm tra mã rỗng/sai)
            Real real = new Real();
            var personReal = real.CreatePerson("Nguyen Kim Ngan", "AB");
            Console.WriteLine($"[REAL] {personReal.Name} - Nhóm máu: {personReal.BloodGroup.Code} ({personReal.BloodGroup.Description})");

            Console.ReadLine();
        }
    }
}