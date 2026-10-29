using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH03_30_IntroduceNullObject
{
    // Tái cấu trúc: Áp dụng Null Object Pattern với lớp trừu tượng đại diện cho khách hàng và lớp con xử lý giá trị mặc định
    public abstract class CustomerAfter
    {
        public abstract string Name { get; }
        public abstract string Plan { get; }
        public abstract bool IsNull { get; }
    }

    public class RealCustomerAfter : CustomerAfter
    {
        public override string Name { get; }
        public override string Plan { get; }
        public override bool IsNull => false;

        public RealCustomerAfter(string name, string plan)
        {
            Name = name;
            Plan = plan;
        }
    }

    public class NullCustomerAfter : CustomerAfter
    {
        public override string Name => "Khách vãng lai";
        public override string Plan => "Gói mặc định";
        public override bool IsNull => true;
    }

    public class After
    {
        public string GetCustomerPlanName(CustomerAfter customer)
        {
            // Không cần câu lệnh if (customer == null)
            CustomerAfter safeCustomer = customer ?? new NullCustomerAfter();
            return safeCustomer.Plan;
        }
    }
}