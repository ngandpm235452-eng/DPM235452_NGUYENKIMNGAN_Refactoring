using System;
using System.Collections.Generic;

namespace DPM235452_NGUYENKIMNGAN_BTTH04_45_PreserveWholeObject
{
    public class Room
    {
        public string RoomName { get; set; }
        public TempRange TemperatureRange { get; set; }

        public Room(string name, TempRange tempRange)
        {
            RoomName = name;
            TemperatureRange = tempRange;
        }
    }

    public class Real
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            HeatingPlanAfter plan = new HeatingPlanAfter();

            List<Room> rooms = new List<Room>
            {
                new Room("Phòng làm việc", new TempRange(19, 23)),  // Trong ngưỡng an toàn (18°C - 25°C)
                new Room("Phòng máy chủ", new TempRange(15, 28))   // Vượt ngưỡng an toàn
            };

            Console.WriteLine("==================================================");
            Console.WriteLine("   HỆ THỐNG KIỂM SOÁT NHIỆT ĐỘ PHÒNG ĐIỀU HÒA    ");
            Console.WriteLine("==================================================\n");

            foreach (var room in rooms)
            {
                // Truyền toàn bộ đối tượng room.TemperatureRange trực tiếp vào hàm
                bool isSafe = plan.WithinRange(room.TemperatureRange);

                Console.WriteLine($"Khu vực: {room.RoomName}");
                Console.WriteLine($"  - Dải nhiệt độ đo được : {room.TemperatureRange.Low}°C - {room.TemperatureRange.High}°C");
                Console.WriteLine($"  - Đánh giá tiêu chuẩn   : {(isSafe ? "Đạt tiêu chuẩn" : "Cảnh báo vượt ngưỡng")}\n");
            }

            Console.WriteLine("==================================================");
            Console.ReadLine();
        }
    }
}