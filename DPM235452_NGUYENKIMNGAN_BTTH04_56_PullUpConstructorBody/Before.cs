using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH04_56_PullUpConstructorBody
{
    public class EmployeeBefore
    {
        protected string _id;
        protected string _name;
    }

    public class ManagerBefore : EmployeeBefore
    {
        private int _grade;

        // Vi phạm: Gán _id và _name lặp đi lặp lại trong Constructor của từng lớp con
        public ManagerBefore(string id, string name, int grade)
        {
            _id = id;
            _name = name;
            _grade = grade;
        }
    }

    public class EngineerBefore : EmployeeBefore
    {
        private string _specialization;

        // Vi phạm: Đoạn mã gán _id và _name trùng lặp với ManagerBefore
        public EngineerBefore(string id, string name, string specialization)
        {
            _id = id;
            _name = name;
            _specialization = specialization;
        }
    }
}