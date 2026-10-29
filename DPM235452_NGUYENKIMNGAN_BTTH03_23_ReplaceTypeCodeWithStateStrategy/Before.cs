using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH03_23_ReplaceTypeCodeWithStateStrategy
{
    public class EmployeeBefore
    {
        // Code Smell: Primitive Obsession / Mutable Type Code - Dùng mã int để đại diện loại nhân viên có thể thay đổi trong vòng đời đối tượng
        public const int ENGINEER = 0;
        public const int SALESMAN = 1;
        public const int MANAGER = 2;

        public int Type { get; set; }
        public double MonthlySalary { get; set; }
        public double Commission { get; set; }
        public double Bonus { get; set; }

        public EmployeeBefore(int type, double monthlySalary, double commission = 0, double bonus = 0)
        {
            Type = type;
            MonthlySalary = monthlySalary;
            Commission = commission;
            Bonus = bonus;
        }

        public double CalculatePay()
        {
            return Type switch
            {
                ENGINEER => MonthlySalary,
                SALESMAN => MonthlySalary + Commission,
                MANAGER => MonthlySalary + Bonus,
                _ => throw new InvalidOperationException("Mã loại nhân viên không hợp lệ.")
            };
        }
    }

    public class Before
    {
        public double Calculate()
        {
            var emp = new EmployeeBefore(EmployeeBefore.ENGINEER, 1000);
            // Mã loại thay đổi lúc Runtime làm tăng rủi ro khi dùng switch-case
            emp.Type = EmployeeBefore.MANAGER;
            emp.Bonus = 500;
            return emp.CalculatePay();
        }
    }
}