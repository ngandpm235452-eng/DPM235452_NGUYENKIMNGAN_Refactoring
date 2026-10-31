using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH04_40_AddParameter
{
    public class InvoiceBefore
    {
        private double subtotal;

        public InvoiceBefore(double subtotal)
        {
            this.subtotal = subtotal;
        }

        // Phương thức tính tổng tiền thiếu tham số thuế suất, đang áp dụng thuế mặc định 10%
        public double CalculateTotal()
        {
            double defaultTaxRate = 0.10; // 10% cố định
            return subtotal + (subtotal * defaultTaxRate);
        }
    }
}