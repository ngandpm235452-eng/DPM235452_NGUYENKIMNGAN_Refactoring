using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH04_44_ReplaceParameterWithExplicitMethods
{
    public class RectangleBefore
    {
        private int _height;
        private int _width;

        public int Height => _height;
        public int Width => _width;

        // Phương thức dùng tham số 'name' để điều hướng gán giá trị, dễ gây lỗi chính tả chuỗi
        public void SetValue(string name, int value)
        {
            if (name.Equals("height", StringComparison.OrdinalIgnoreCase))
            {
                _height = value;
                return;
            }
            if (name.Equals("width", StringComparison.OrdinalIgnoreCase))
            {
                _width = value;
                return;
            }
            throw new ArgumentException("Tên thuộc tính không hợp lệ!");
        }
    }
}