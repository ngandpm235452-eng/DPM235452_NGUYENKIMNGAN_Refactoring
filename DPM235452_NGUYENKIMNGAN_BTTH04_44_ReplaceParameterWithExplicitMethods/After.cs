using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH04_44_ReplaceParameterWithExplicitMethods
{
    public class RectangleAfter
    {
        private int _height;
        private int _width;

        public int Height => _height;
        public int Width => _width;

        // Tái cấu trúc: Tạo phương thức rõ ràng cho việc gán chiều cao
        public void SetHeight(int value)
        {
            _height = value;
        }

        // Tái cấu trúc: Tạo phương thức rõ ràng cho việc gán chiều rộng
        public void SetWidth(int value)
        {
            _width = value;
        }
    }
}