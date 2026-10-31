using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH04_62_CollapseHierarchy
{
    // Tái cấu trúc: Gộp lớp con SalesmanBefore vào lớp EmployeeAfter (Collapse Hierarchy)
    // giúp loại bỏ các lớp thừa không còn vai trò riêng biệt
    public class EmployeeAfter
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public EmployeeAfter(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }
    }
}