using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH03_23_ReplaceTypeCodeWithStateStrategy
{
    // Tái cấu trúc: Áp dụng State/Strategy Pattern với lớp trừu tượng đại diện cho trạng thái/chức vụ
    public abstract class EmployeeTypeAfter
    {
        public abstract int TypeCode { get; }
        public abstract double CalculatePay(EmployeeAfter employee);
    }

    public class EngineerAfter : EmployeeTypeAfter
    {
        public override int TypeCode => 0;
        public override double CalculatePay(EmployeeAfter employee) => employee.MonthlySalary;
    }

    public class SalesmanAfter : EmployeeTypeAfter
    {
        public override int TypeCode => 1;
        public override double CalculatePay(EmployeeAfter employee) => employee.MonthlySalary + employee.Commission;
    }

    public class ManagerAfter : EmployeeTypeAfter
    {
        public override int TypeCode => 2;
        public override double CalculatePay(EmployeeAfter employee) => employee.MonthlySalary + employee.Bonus;
    }

    public class EmployeeAfter
    {
        public EmployeeTypeAfter Type { get; set; }
        public double MonthlySalary { get; set; }
        public double Commission { get; set; }
        public double Bonus { get; set; }

        public EmployeeAfter(EmployeeTypeAfter type, double monthlySalary, double commission = 0, double bonus = 0)
        {
            Type = type;
            MonthlySalary = monthlySalary;
            Commission = commission;
            Bonus = bonus;
        }

        public double CalculatePay() => Type.CalculatePay(this);
    }

    public class After
    {
        public double Calculate()
        {
            var emp = new EmployeeAfter(new EngineerAfter(), 1000);
            // Chuyển đổi trạng thái/chiến lược động ở Runtime an toàn
            emp.Type = new ManagerAfter();
            emp.Bonus = 500;
            return emp.CalculatePay();
        }
    }
}