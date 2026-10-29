using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH03_30_IntroduceNullObject
{
    public class CustomerBefore
    {
        public string Name { get; set; }
        public string Plan { get; set; }
    }

    public class Before
    {
        public string GetCustomerPlanName(CustomerBefore customer)
        {
            // Code Smell: Null Checks - Kiểm tra null lặp đi lặp lại ở nhiều nơi trước khi truy cập thuộc tính
            if (customer == null)
            {
                return "Gói mặc định (Khách vãng lai)";
            }
            return customer.Plan ?? "Gói cơ bản";
        }
    }
}