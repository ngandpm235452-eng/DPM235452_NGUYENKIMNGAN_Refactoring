using System;
using System.Collections.Generic;

namespace DPM235452_NGUYENKIMNGAN_BTTH04_60_ExtractSuperclass
{
    public class EmployeeBefore
    {
        private string _name;
        private string _id;
        private double _monthlySalary;

        public EmployeeBefore(string name, string id, double monthlySalary)
        {
            _name = name;
            _id = id;
            _monthlySalary = monthlySalary;
        }

        public string Name => _name;
        public string Id => _id;

        // Vi phạm: EmployeeBefore và DepartmentBefore có đặc tính chung (Tên, Chi phí hàng năm)
        // nhưng trùng lặp giao diện và không có lớp cha chung để quản lý đa hình
        public double GetAnnualCost()
        {
            return _monthlySalary * 12;
        }
    }

    public class DepartmentBefore
    {
        private string _name;
        private List<EmployeeBefore> _staff = new List<EmployeeBefore>();

        public DepartmentBefore(string name)
        {
            _name = name;
        }

        public string Name => _name;

        public void AddStaff(EmployeeBefore emp) => _staff.Add(emp);

        public double GetAnnualCost()
        {
            double total = 0;
            foreach (var emp in _staff)
            {
                total += emp.GetAnnualCost();
            }
            return total;
        }
    }
}