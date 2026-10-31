using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH04_35_ReplaceNestedConditionalWithGuardClauses
{
    public class Employee
    {
        public bool IsDead { get; set; }
        public bool IsSeparated { get; set; }
        public bool IsRetired { get; set; }

        public Employee(bool isDead, bool isSeparated, bool isRetired)
        {
            IsDead = isDead;
            IsSeparated = isSeparated;
            IsRetired = isRetired;
        }
    }

    public class PayrollBefore
    {
        public double GetPayAmount(Employee employee)
        {
            double result;

            // Điều kiện lồng nhau phức tạp (Nested Conditionals)
            if (employee.IsDead)
            {
                result = DeadAmount();
            }
            else
            {
                if (employee.IsSeparated)
                {
                    result = SeparatedAmount();
                }
                else
                {
                    if (employee.IsRetired)
                    {
                        result = RetiredAmount();
                    }
                    else
                    {
                        result = NormalPayAmount();
                    }
                }
            }

            return result;
        }

        private double DeadAmount() => 1000.0;
        private double SeparatedAmount() => 2000.0;
        private double RetiredAmount() => 3000.0;
        private double NormalPayAmount() => 5000.0;
    }
}