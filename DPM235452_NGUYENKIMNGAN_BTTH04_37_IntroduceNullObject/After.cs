using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH04_37_IntroduceNullObject
{
    // Lớp trừu tượng định nghĩa hợp đồng chung
    public abstract class AbstractPlan
    {
        public abstract string Name { get; }
        public abstract bool IsNull { get; }
    }

    // Lớp đối tượng thực tế
    public class RealPlan : AbstractPlan
    {
        private readonly string _name;
        public override string Name => _name;
        public override bool IsNull => false;

        public RealPlan(string name) => _name = name;
    }

    // Lớp Null Object đại diện cho trường hợp giá trị rỗng/mặc định
    public class NullPlan : AbstractPlan
    {
        public override string Name => "Gói cơ bản (Mặc định)";
        public override bool IsNull => true;
    }

    public class CustomerAfter
    {
        public string Name { get; set; }
        public AbstractPlan Plan { get; set; }

        public CustomerAfter(string name, AbstractPlan plan)
        {
            Name = name;
            // Nếu truyền null thì tự động gán bằng Null Object
            Plan = plan ?? new NullPlan();
        }
    }

    public class CustomerServiceAfter
    {
        public void DisplayCustomerPlan(CustomerAfter customer)
        {
            // Không cần kiểm tra null, gọi trực tiếp phương thức/thuộc tính
            Console.WriteLine($"Gói dịch vụ: {customer.Plan.Name}");
        }
    }
}