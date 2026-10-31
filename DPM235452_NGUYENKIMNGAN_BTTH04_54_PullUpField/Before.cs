using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH04_54_PullUpField
{
    public abstract class EmployeeBefore
    {
        // Lớp cha không khai báo trường _name
    }

    public class SalesmanBefore : EmployeeBefore
    {
        // Vi phạm: Trường _name bị khai báo lặp lại ở lớp con Salesman
        protected string _name;

        public SalesmanBefore(string name)
        {
            _name = name;
        }

        public string GetName() => _name;
    }

    public class EngineerBefore : EmployeeBefore
    {
        // Vi phạm: Trường _name bị khai báo lặp lại ở lớp con Engineer
        protected string _name;

        public EngineerBefore(string name)
        {
            _name = name;
        }

        public string GetName() => _name;
    }
}