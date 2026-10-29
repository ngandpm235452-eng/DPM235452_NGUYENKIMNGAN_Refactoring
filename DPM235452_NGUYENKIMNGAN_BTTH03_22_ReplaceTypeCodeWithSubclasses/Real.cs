using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH03_22_ReplaceTypeCodeWithSubclasses
{
    public enum EmployeeTypeReal
    {
        Engineer,
        Salesman,
        Manager
    }

    // Ứng dụng thực tế: Thiết kế abstract class strongly-typed, Factory Pattern, bảo vệ dữ liệu với Validation
    public abstract class EmployeeReal
    {
        public string Name { get; }
        public double BaseSalary { get; }

        protected EmployeeReal(string name, double baseSalary)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Tên nhân viên không được để trống.", nameof(name));
            if (baseSalary < 0)
                throw new ArgumentOutOfRangeException(nameof(baseSalary), "Lương cơ bản không được nhỏ hơn 0.");

            Name = name.Trim();
            BaseSalary = baseSalary;
        }

        public abstract double CalculateTotalPay();
    }

    public class EngineerReal : EmployeeReal
    {
        public EngineerReal(string name, double baseSalary) : base(name, baseSalary) { }

        public override double CalculateTotalPay() => BaseSalary;
    }

    public class SalesmanReal : EmployeeReal
    {
        public double Commission { get; }

        public SalesmanReal(string name, double baseSalary, double commission) : base(name, baseSalary)
        {
            if (commission < 0)
                throw new ArgumentOutOfRangeException(nameof(commission), "Hoa hồng không được nhỏ hơn 0.");
            Commission = commission;
        }

        public override double CalculateTotalPay() => BaseSalary + Commission;
    }

    public class ManagerReal : EmployeeReal
    {
        public double Bonus { get; }

        public ManagerReal(string name, double baseSalary, double bonus) : base(name, baseSalary)
        {
            if (bonus < 0)
                throw new ArgumentOutOfRangeException(nameof(bonus), "Tiền thưởng không được nhỏ hơn 0.");
            Bonus = bonus;
        }

        public override double CalculateTotalPay() => BaseSalary + Bonus;
    }

    public static class EmployeeFactoryReal
    {
        public static EmployeeReal Create(EmployeeTypeReal type, string name, double baseSalary, double extraAmount = 0)
        {
            return type switch
            {
                EmployeeTypeReal.Engineer => new EngineerReal(name, baseSalary),
                EmployeeTypeReal.Salesman => new SalesmanReal(name, baseSalary, extraAmount),
                EmployeeTypeReal.Manager => new ManagerReal(name, baseSalary, extraAmount),
                _ => throw new ArgumentOutOfRangeException(nameof(type), "Loại nhân viên không được hỗ trợ.")
            };
        }
    }

    public class Real
    {
        public EmployeeReal CreateEmployee(EmployeeTypeReal type, string name, double baseSalary, double extra = 0)
        {
            return EmployeeFactoryReal.Create(type, name, baseSalary, extra);
        }
    }
}