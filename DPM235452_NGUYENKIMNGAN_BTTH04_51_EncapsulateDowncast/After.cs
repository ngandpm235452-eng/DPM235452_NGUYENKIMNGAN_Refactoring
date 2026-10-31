using System;
using System.Collections;

namespace DPM235452_NGUYENKIMNGAN_BTTH04_51_EncapsulateDowncast
{
    public class SiteAfter
    {
        private ArrayList _readings = new ArrayList();

        public void AddReading(Reading reading)
        {
            _readings.Add(reading);
        }

        // Tái cấu trúc: Đóng gói phép ép kiểu xuống (Downcast) bên trong phương thức
        // Giúp nơi gọi nhận trực tiếp kiểu dữ liệu cụ thể Reading
        public Reading LastReading()
        {
            if (_readings.Count == 0) return null;
            return (Reading)_readings[_readings.Count - 1];
        }
    }
}