using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH04_37_IntroduceNullObject
{
    public class PlanBefore
    {
        public string Name { get; set; }
        public PlanBefore(string name) => Name = name;
    }

    public class CustomerBefore
    {
        public string Name { get; set; }
        public PlanBefore Plan { get; set; }

        public CustomerBefore(string name, PlanBefore plan)
        {
            Name = name;
            Plan = plan;
        }
    }

    public class CustomerServiceBefore
    {
        public void DisplayCustomerPlan(CustomerBefore customer)
        {
            // Liên tục kiểm tra null trước khi truy cập thuộc tính
            string planName;
            if (customer == null || customer.Plan == null)
            {
                planName = "Gói cơ bản (Mặc định)";
            }
            else
            {
                planName = customer.Plan.Name;
            }

            Console.WriteLine($"Gói dịch vụ: {planName}");
        }
    }
}