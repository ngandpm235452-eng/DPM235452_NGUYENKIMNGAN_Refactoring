using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH04_36_ReplaceConditionalWithPolymorphism
{
    // Lớp cha trừu tượng
    public abstract class EmployeeAfter
    {
        protected double monthlySalary = 3000;

        // Phương thức tính lương trừu tượng
        public abstract double GetPayAmount();
    }

    // Lớp con Kỹ sư
    public class Engineer : EmployeeAfter
    {
        public override double GetPayAmount()
        {
            return monthlySalary;
        }
    }

    // Lớp con Nhân viên bán hàng
    public class Salesman : EmployeeAfter
    {
        private double commission = 500;

        public override double GetPayAmount()
        {
            return monthlySalary + commission;
        }
    }

    // Lớp con Quản lý
    public class Manager : EmployeeAfter
    {
        private double bonus = 1000;

        public override double GetPayAmount()
        {
            return monthlySalary + bonus;
        }
    }
}