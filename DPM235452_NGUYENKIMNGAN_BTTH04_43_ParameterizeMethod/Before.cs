using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH04_43_ParameterizeMethod
{
    public class EmployeeBefore
    {
        public double Salary { get; private set; }

        public EmployeeBefore(double salary)
        {
            Salary = salary;
        }

        // Tăng lương 10%
        public void TenPercentRaise()
        {
            Salary *= 1.10;
        }

        // Tăng lương 5% - Đoạn mã bị lặp lại cấu trúc với TenPercentRaise
        public void FivePercentRaise()
        {
            Salary *= 1.05;
        }
    }
}