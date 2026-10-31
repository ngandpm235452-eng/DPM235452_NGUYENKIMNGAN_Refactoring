using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH04_55_PullUpMethod
{
    public abstract class CustomerAfter
    {
        // Tái cấu trúc: Đẩy phương thức chung CalculatePoints lên lớp cha để tái sử dụng
        public int CalculatePoints(double amount)
        {
            return (int)(amount / 10);
        }
    }

    public class RegularCustomerAfter : CustomerAfter
    {
    }

    public class VipCustomerAfter : CustomerAfter
    {
    }
}