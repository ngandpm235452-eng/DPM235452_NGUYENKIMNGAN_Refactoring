using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH04_54_PullUpField
{
    public abstract class EmployeeAfter
    {
        // Tái cấu trúc: Đẩy trường dữ liệu chung _name lên lớp cha để dùng chung
        protected string _name;

        public EmployeeAfter(string name)
        {
            _name = name;
        }

        public string GetName() => _name;
    }

    public class SalesmanAfter : EmployeeAfter
    {
        public SalesmanAfter(string name) : base(name)
        {
        }
    }

    public class EngineerAfter : EmployeeAfter
    {
        public EngineerAfter(string name) : base(name)
        {
        }
    }
}