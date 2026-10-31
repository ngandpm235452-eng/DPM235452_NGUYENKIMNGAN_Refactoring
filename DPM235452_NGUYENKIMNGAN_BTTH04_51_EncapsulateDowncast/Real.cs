using System;
using System.Collections.Generic;

namespace DPM235452_NGUYENKIMNGAN_BTTH04_51_EncapsulateDowncast
{
    public class Real
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            SiteAfter meterSite = new SiteAfter();
            meterSite.AddReading(new Reading(120, new DateTime(2026, 3, 1)));
            meterSite.AddReading(new Reading(155, new DateTime(2026, 3, 15)));
            meterSite.AddReading(new Reading(210, new DateTime(2026, 3, 31)));

            Console.WriteLine("==================================================");
            Console.WriteLine("    HỆ THỐNG GIÁM SÁT CHỈ SỐ TIÊU THỤ ĐIỆN NĂNG   ");
            Console.WriteLine("==================================================\n");

            // Bên gọi nhận ngay kiểu Reading mà không cần phải thực hiện ép kiểu (Reading)site.LastReading()
            Reading lastReading = meterSite.LastReading();

            if (lastReading != null)
            {
                Console.WriteLine("Thông tin chỉ số mới nhất thu thập được:");
                Console.WriteLine($"  - Ngày ghi nhận : {lastReading.Date:dd/MM/yyyy}");
                Console.WriteLine($"  - Chỉ số điện   : {lastReading.Value} kWh\n");
            }

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Lưu ý: Phép ép kiểu (Downcast) đã được đóng gói");
            Console.WriteLine("trong phương thức LastReading(), giúp mã nguồn bên ngoài");
            Console.WriteLine("sạch sẽ hơn và tránh lặp lại các đoạn ép kiểu.");
            Console.WriteLine("==================================================");

            Console.ReadLine();
        }
    }
}