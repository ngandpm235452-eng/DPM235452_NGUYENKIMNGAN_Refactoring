using System;
using System.Collections.Generic;

namespace DPM235452_NGUYENKIMNGAN_BTTH04_60_ExtractSuperclass
{
    // Tái cấu trúc: Trích xuất lớp trừu tượng cha PartyAfter đại diện cho thực thể có tên và chi phí
    public abstract class PartyAfter
    {
        private string _name;

        protected PartyAfter(string name)
        {
            _name = name;
        }

        public string Name => _name;

        // Phương thức trừu tượng buộc các lớp con phải tự triển khai chi tiết tính toán
        public abstract double GetAnnualCost();
    }

    public class EmployeeAfter : PartyAfter
    {
        private string _id;
        private double _monthlySalary;

        public EmployeeAfter(string name, string id, double monthlySalary) : base(name)
        {
            _id = id;
            _monthlySalary = monthlySalary;
        }

        public string Id => _id;

        public override double GetAnnualCost()
        {
            return _monthlySalary * 12;
        }
    }

    public class DepartmentAfter : PartyAfter
    {
        private List<PartyAfter> _members = new List<PartyAfter>();

        public DepartmentAfter(string name) : base(name)
        {
        }

        public void AddMember(PartyAfter member) => _members.Add(member);

        public override double GetAnnualCost()
        {
            double total = 0;
            foreach (var member in _members)
            {
                total += member.GetAnnualCost();
            }
            return total;
        }
    }
}