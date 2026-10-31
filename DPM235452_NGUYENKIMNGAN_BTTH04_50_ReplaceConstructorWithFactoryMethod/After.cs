using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH04_50_ReplaceConstructorWithFactoryMethod
{
    public class EmployeeAfter
    {
        public const int ENGINEER = 0;
        public const int MANAGER = 1;

        public int Type { get; private set; }

        // Chuyển Constructor về private để ngăn cấm việc khởi tạo trực tiếp từ bên ngoài
        private EmployeeAfter(int type)
        {
            Type = type;
        }

        // Tái cấu trúc: Tạo Factory Method cho đối tượng Kỹ sư
        public static EmployeeAfter CreateEngineer()
        {
            return new EmployeeAfter(ENGINEER);
        }

        // Tái cấu trúc: Tạo Factory Method cho đối tượng Quản lý
        public static EmployeeAfter CreateManager()
        {
            return new EmployeeAfter(MANAGER);
        }
    }
}