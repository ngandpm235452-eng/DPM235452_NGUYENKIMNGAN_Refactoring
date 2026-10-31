using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH04_57_PushDownMethod
{
    public class EmployeeBefore
    {
        // Vi phạm: Phương thức GetQuota() nằm ở lớp cha Employee nhưng chỉ áp dụng cho Nhân viên Kinh doanh
        public double GetQuota()
        {
            return 1000.0;
        }
    }

    public class EngineerBefore : EmployeeBefore
    {
        // Kỹ sư kế thừa GetQuota() mặc dù không sử dụng chỉ tiêu doanh số
    }

    public class SalesmanBefore : EmployeeBefore
    {
        // Nhân viên kinh doanh thực sự cần GetQuota()
    }
}