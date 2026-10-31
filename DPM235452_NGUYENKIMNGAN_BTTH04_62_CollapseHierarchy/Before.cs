using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH04_62_CollapseHierarchy
{
    public class EmployeeBefore
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public EmployeeBefore(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }
    }

    // Vi phạm: Lớp con SalesmanBefore không còn bổ sung thuộc tính hay hành vi mới đáng kể nào so với lớp cha EmployeeBefore
    public class SalesmanBefore : EmployeeBefore
    {
        public SalesmanBefore(string name, double salary) : base(name, salary)
        {
        }
    }
}