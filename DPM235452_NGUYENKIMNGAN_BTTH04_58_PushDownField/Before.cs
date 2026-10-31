using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH04_58_PushDownField
{
    public class EmployeeBefore
    {
        // Vi phạm: Trường _quota nằm ở lớp cha nhưng chỉ có lớp SalesmanBefore sử dụng
        protected double _quota;
    }

    public class EngineerBefore : EmployeeBefore
    {
        // Kỹ sư kế thừa trường _quota dù không bao giờ sử dụng
    }

    public class SalesmanBefore : EmployeeBefore
    {
        public void SetQuota(double quota)
        {
            _quota = quota;
        }

        public double GetQuota() => _quota;
    }
}