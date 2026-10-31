using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH04_40_AddParameter
{
    public class InvoiceAfter
    {
        private double subtotal;

        public InvoiceAfter(double subtotal)
        {
            this.subtotal = subtotal;
        }

        // Tái cấu trúc: Thêm tham số taxRate để cho phép bên gọi truyền vào mức thuế tùy chỉnh
        public double CalculateTotal(double taxRate)
        {
            return subtotal + (subtotal * taxRate);
        }
    }
}