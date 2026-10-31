using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH04_56_PullUpConstructorBody
{
    public class EmployeeAfter
    {
        protected string _id;
        protected string _name;

        public string Id => _id;
        public string Name => _name;

        // Tái cấu trúc: Đưa phần gán trường dữ liệu chung vào Constructor của lớp cha
        protected EmployeeAfter(string id, string name)
        {
            _id = id;
            _name = name;
        }
    }

    public class ManagerAfter : EmployeeAfter
    {
        private int _grade;
        public int Grade => _grade;

        // Gọi base(id, name) để tái sử dụng Constructor lớp cha, chỉ gán thuộc tính riêng
        public ManagerAfter(string id, string name, int grade) : base(id, name)
        {
            _grade = grade;
        }
    }

    public class EngineerAfter : EmployeeAfter
    {
        private string _specialization;
        public string Specialization => _specialization;

        // Gọi base(id, name) để tái sử dụng Constructor lớp cha, chỉ gán thuộc tính riêng
        public EngineerAfter(string id, string name, string specialization) : base(id, name)
        {
            _specialization = specialization;
        }
    }
}