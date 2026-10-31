using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH04_55_PullUpMethod
{
    public abstract class CustomerBefore
    {
        // Lớp cha không khai báo phương thức CalculatePoints
    }

    public class RegularCustomerBefore : CustomerBefore
    {
        // Vi phạm: Phương thức CalculatePoints bị lặp lại ở lớp con
        public int CalculatePoints(double amount)
        {
            return (int)(amount / 10);
        }
    }

    public class VipCustomerBefore : CustomerBefore
    {
        // Vi phạm: Phương thức CalculatePoints trùng lặp logic hệt như RegularCustomerBefore
        public int CalculatePoints(double amount)
        {
            return (int)(amount / 10);
        }
    }
}