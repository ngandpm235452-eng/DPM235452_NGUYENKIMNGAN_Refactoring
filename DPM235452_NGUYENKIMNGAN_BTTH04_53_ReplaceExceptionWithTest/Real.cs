using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH04_53_ReplaceExceptionWithTest
{
    public class Real
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            ResourcePoolAfter pool = new ResourcePoolAfter();

            Console.WriteLine("==================================================");
            Console.WriteLine("    HỆ THỐNG CẤP PHÁT TÀI NGUYÊN (PRE-CHECK)     ");
            Console.WriteLine("==================================================\n");

            Console.WriteLine("Yêu cầu lấy tài nguyên lần 1: " + pool.GetResource());
            Console.WriteLine("Yêu cầu lấy tài nguyên lần 2: " + pool.GetResource());
            Console.WriteLine("Yêu cầu lấy tài nguyên lần 3: " + pool.GetResource());
            Console.WriteLine("Yêu cầu lấy tài nguyên lần 4: " + pool.GetResource() + "\n");

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Lưu ý: Thay vì để chương trình gặp Exception khi Stack rỗng,");
            Console.WriteLine("phương thức chủ động kiểm tra điều kiện (Count == 0)");
            Console.WriteLine("giúp tăng hiệu năng và luồng mã nguồn minh bạch.");
            Console.WriteLine("==================================================");

            Console.ReadLine();
        }
    }
}