using System;
using System.Collections.Generic;

namespace DPM235452_NGUYENKIMNGAN_BTTH04_44_ReplaceParameterWithExplicitMethods
{
    public class ScreenDisplay
    {
        public string DisplayName { get; set; }
        public RectangleAfter Resolution { get; set; }

        public ScreenDisplay(string name)
        {
            DisplayName = name;
            Resolution = new RectangleAfter();
        }
    }

    public class Real
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            List<ScreenDisplay> screens = new List<ScreenDisplay>();

            // Màn hình 1: Full HD
            ScreenDisplay fhd = new ScreenDisplay("Màn hình Full HD");
            fhd.Resolution.SetWidth(1920);  // Gọi phương thức rõ ràng SetWidth
            fhd.Resolution.SetHeight(1080); // Gọi phương thức rõ ràng SetHeight
            screens.Add(fhd);

            // Màn hình 2: 4K Ultra HD
            ScreenDisplay uhd = new ScreenDisplay("Màn hình 4K UHD");
            uhd.Resolution.SetWidth(3840);
            uhd.Resolution.SetHeight(2160);
            screens.Add(uhd);

            Console.WriteLine("==================================================");
            Console.WriteLine("   HỆ THỐNG CẤU HÌNH ĐỘ PHÂN GIẢI MÀN HÌNH         ");
            Console.WriteLine("==================================================\n");

            foreach (var screen in screens)
            {
                Console.WriteLine($"Thiết bị: {screen.DisplayName}");
                Console.WriteLine($"  - Chiều rộng : {screen.Resolution.Width} px");
                Console.WriteLine($"  - Chiều cao  : {screen.Resolution.Height} px");
                Console.WriteLine($"  -> Độ phân giải: {screen.Resolution.Width} x {screen.Resolution.Height}\n");
            }

            Console.WriteLine("==================================================");
            Console.ReadLine();
        }
    }
}