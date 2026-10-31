using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH04_50_ReplaceConstructorWithFactoryMethod
{
    public class EmployeeBefore
    {
        public const int ENGINEER = 0;
        public const int MANAGER = 1;

        public int Type { get; set; }

        // Vi phạm: Constructor nhận tham số mã loại làm mơ hồ mục đích khởi tạo và không tự giải thích
        public EmployeeBefore(int type)
        {
            Type = type;
        }
    }
}