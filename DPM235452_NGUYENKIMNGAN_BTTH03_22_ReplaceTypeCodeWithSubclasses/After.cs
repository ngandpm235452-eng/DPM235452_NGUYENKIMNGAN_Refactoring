using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH03_22_ReplaceTypeCodeWithSubclasses
{
    // Tái cấu trúc: Biến lớp chính thành abstract và kế thừa các lớp con ứng với từng loại nhân viên
    public abstract class EmployeeAfter
    {
        public double MonthlySalary { get; set; }

        protected EmployeeAfter(double monthlySalary)
        {
            MonthlySalary = monthlySalary;
        }

        public abstract double CalculatePay();

        public static EmployeeAfter Create(int type, double monthlySalary, double commission = 0, double bonus = 0)
        {
            return type switch
            {
                0 => new EngineerAfter(monthlySalary),
                1 => new SalesmanAfter(monthlySalary, commission),
                2 => new ManagerAfter(monthlySalary, bonus),
                _ => throw new ArgumentException("Mã loại nhân viên không hợp lệ.")
            };
        }
    }

    public class EngineerAfter : EmployeeAfter
    {
        public EngineerAfter(double monthlySalary) : base(monthlySalary) { }
        public override double CalculatePay() => MonthlySalary;
    }

    public class SalesmanAfter : EmployeeAfter
    {
        public double Commission { get; set; }
        public SalesmanAfter(double monthlySalary, double commission) : base(monthlySalary)
        {
            Commission = commission;
        }
        public override double CalculatePay() => MonthlySalary + Commission;
    }

    public class ManagerAfter : EmployeeAfter
    {
        public double Bonus { get; set; }
        public ManagerAfter(double monthlySalary, double bonus) : base(monthlySalary)
        {
            Bonus = bonus;
        }
        public override double CalculatePay() => MonthlySalary + Bonus;
    }

    public class After
    {
        public double GetEngineerPay()
        {
            var emp = EmployeeAfter.Create(0, 1000);
            return emp.CalculatePay();
        }
    }
}