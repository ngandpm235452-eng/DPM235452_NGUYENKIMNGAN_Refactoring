using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH03_22_ReplaceTypeCodeWithSubclasses
{
    public class EmployeeBefore
    {
        // Code Smell: Primitive Obsession / Switch Statements - Dùng hằng số int làm mã loại và switch-case để tính toán
        public const int ENGINEER = 0;
        public const int SALESMAN = 1;
        public const int MANAGER = 2;

        public int Type { 範 set; get; }
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
        public double GetEngineerPay()
        {
            var emp = new EmployeeBefore(EmployeeBefore.ENGINEER, 1000);
            return emp.CalculatePay();
        }
    }
}