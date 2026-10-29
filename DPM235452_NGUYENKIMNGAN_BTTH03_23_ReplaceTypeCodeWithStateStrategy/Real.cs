using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH03_23_ReplaceTypeCodeWithStateStrategy
{
    // Ứng dụng thực tế: Strategy Pattern hoàn chỉnh với sealed class, kiểm tra dữ liệu đầu vào và chuyển đổi chức vụ an toàn
    public abstract class RoleStrategyReal
    {
        public abstract string RoleName { get; }
        public abstract double CalculatePay(EmployeeReal employee);
    }

    public sealed class EngineerRoleReal : RoleStrategyReal
    {
        public override string RoleName => "Kỹ sư";
        public override double CalculatePay(EmployeeReal employee) => employee.BaseSalary;
    }

    public sealed class SalesmanRoleReal : RoleStrategyReal
    {
        public override string RoleName => "Nhân viên kinh doanh";
        public override double CalculatePay(EmployeeReal employee) => employee.BaseSalary + employee.Commission;
    }

    public sealed class ManagerRoleReal : RoleStrategyReal
    {
        public override string RoleName => "Quản lý";
        public override double CalculatePay(EmployeeReal employee) => employee.BaseSalary + employee.Bonus;
    }

    public class EmployeeReal
    {
        private RoleStrategyReal _roleStrategy;

        public string Name { get; }
        public double BaseSalary { get; }
        public double Commission { get; private set; }
        public double Bonus { get; private set; }

        public RoleStrategyReal RoleStrategy
        {
            get => _roleStrategy;
            set => _roleStrategy = value ?? throw new ArgumentNullException(nameof(value), "Vai trò/Chiến lược không được để trống.");
        }

        public EmployeeReal(string name, double baseSalary, RoleStrategyReal initialRole)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Tên nhân viên không được để trống.", nameof(name));
            if (baseSalary < 0)
                throw new ArgumentOutOfRangeException(nameof(baseSalary), "Lương cơ bản không được nhỏ hơn 0.");

            Name = name.Trim();
            BaseSalary = baseSalary;
            _roleStrategy = initialRole ?? throw new ArgumentNullException(nameof(initialRole));
        }

        public void SetCommission(double commission)
        {
            if (commission < 0)
                throw new ArgumentOutOfRangeException(nameof(commission), "Hoa hồng không được nhỏ hơn 0.");
            Commission = commission;
        }

        public void SetBonus(double bonus)
        {
            if (bonus < 0)
                throw new ArgumentOutOfRangeException(nameof(bonus), "Tiền thưởng không được nhỏ hơn 0.");
            Bonus = bonus;
        }

        public double CalculateTotalPay() => _roleStrategy.CalculatePay(this);
    }

    public class Real
    {
        public EmployeeReal CreateEmployee(string name, double baseSalary, RoleStrategyReal initialRole)
        {
            return new EmployeeReal(name, baseSalary, initialRole);
        }
    }
}