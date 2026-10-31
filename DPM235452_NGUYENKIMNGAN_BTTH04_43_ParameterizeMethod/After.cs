using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH04_43_ParameterizeMethod
{
    public class EmployeeAfter
    {
        public double Salary { get; private set; }

        public EmployeeAfter(double salary)
        {
            Salary = salary;
        }

        // Tái cấu trúc: Hợp nhất các phương thức tăng lương thành một phương thức duy nhất có nhận tham số tỷ lệ
        public void Raise(double factor)
        {
            Salary *= (1 + factor);
        }
    }
}