using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH04_57_PushDownMethod
{
    public class EmployeeAfter
    {
        // Lớp cha chỉ giữ lại các đặc tính chung của toàn bộ nhân viên
    }

    public class EngineerAfter : EmployeeAfter
    {
        // Kỹ sư không còn chứa phương thức thừa GetQuota()
    }

    public class SalesmanAfter : EmployeeAfter
    {
        // Tái cấu trúc: Đẩy phương thức GetQuota() xuống đúng lớp con có nhu cầu sử dụng
        public double GetQuota()
        {
            return 1000.0;
        }
    }
}