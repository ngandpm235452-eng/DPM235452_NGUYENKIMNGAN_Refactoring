using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH04_36_ReplaceConditionalWithPolymorphism
{
    public class EmployeeBefore
    {
        public const int ENGINEER = 0;
        public const int SALESMAN = 1;
        public const int MANAGER = 2;

        private int type;
        private double monthlySalary = 3000;
        private double commission = 500;
        private double bonus = 1000;

        public EmployeeBefore(int type)
        {
            this.type = type;
        }

        public double GetPayAmount()
        {
            // Kiểm tra câu lệnh điều kiện/switch theo loại đối tượng
            switch (type)
            {
                case ENGINEER:
                    return monthlySalary;
                case SALESMAN:
                    return monthlySalary + commission;
                case MANAGER:
                    return monthlySalary + bonus;
                default:
                    throw new InvalidOperationException("Loại nhân viên không hợp lệ");
            }
        }
    }
}