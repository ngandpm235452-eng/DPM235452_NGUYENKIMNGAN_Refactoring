using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH04_58_PushDownField
{
    public class EmployeeAfter
    {
        // Tái cấu trúc: Loại bỏ trường _quota khỏi lớp cha
    }

    public class EngineerAfter : EmployeeAfter
    {
        // Kỹ sư không còn mang trường dữ liệu dư thừa
    }

    public class SalesmanAfter : EmployeeAfter
    {
        // Tái cấu trúc: Đẩy trường dữ liệu _quota xuống đúng lớp con có nhu cầu sử dụng
        private double _quota;

        public void SetQuota(double quota)
        {
            _quota = quota;
        }

        public double GetQuota() => _quota;
    }
}